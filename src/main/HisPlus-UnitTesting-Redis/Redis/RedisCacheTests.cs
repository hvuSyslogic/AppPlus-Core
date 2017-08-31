using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentAssertions;
using Xunit;
using HisPlus.Contract.Messages;
using HisPlus.Contract.Services;
using HisPlus.Infrastructure.DependencyInjection;
using HisPlus.UnitTesting.Common;
using HisPlus.Redis;
using HisPlus.Infrastructure.Contract.Messages;
using System.Threading;

namespace HisPlus.UnitTesting.Redis
{
    public partial class RedisCacheUnitTests : RedisTestBase, IClassFixture<RedisTestFixture>
    {
        #region private constant(s)
        private const string TraitName = "RedisCacheUnitTests";
        private const string TraitCacheObjectValue = "Object";
        private const string TraitCacheHashedValue = "Hashed";
        #endregion

        static Func<BsUserDTO, object> KeyBuilder = (x) => { return x.Id; };

        static Func<BsUserDTO, object> HashFieldBuilder = (x) => { return string.Format("ID:{0}", x.Id); };

        Func<BsUserDTO, string[]> TagsBuilder = (x) => 
        {
            return new string[] 
            { 
                string.Format("Code:{0}:Password:{1}", x.Code, x.Password),
                string.Format("Code:{0}:Name:{1}", x.Code, x.Name),
            }; 
        };

        public RedisCacheUnitTests()
        {
            UserKeys = new string[] { KeyBuilder.Invoke(TheFirstUser).ToString(), KeyBuilder.Invoke(TheSecondUser).ToString() };                      
        }

        #region Object cache testing
        [Fact(DisplayName = "set_object")]
        [Trait(TraitName, TraitCacheObjectValue)]
        public void set_object()
        {
            Cache.FlushAll();

            Cache.SetObject<BsUserDTO>(TheFirstUser, KeyBuilder);
            Cache.KeyExists<BsUserDTO>(TheFirstUser, KeyBuilder).Should().BeTrue();

            Cache.SetObject<BsUserDTO>(TheSecondUser, KeyBuilder);
            Cache.KeyExists<BsUserDTO>(TheSecondUser, KeyBuilder).Should().BeTrue();
        }

        [Fact(DisplayName = "set_object_with_ttl")]
        [Trait(TraitName, TraitCacheObjectValue)]
        public void set_object_with_ttl()
        {
            Cache.FlushAll();

            double ms = 3;

            Cache.SetObject<BsUserDTO>(TheFirstUser, KeyBuilder, TimeSpan.FromSeconds(ms));
            Cache.KeyExists<BsUserDTO>(TheFirstUser, KeyBuilder).Should().BeTrue();

            Thread.Sleep(TimeSpan.FromSeconds(ms + 0.5));
            Cache.KeyExists<BsUserDTO>(TheFirstUser, KeyBuilder).Should().BeFalse();            
        }

        [Fact(DisplayName = "get_object")]
        [Trait(TraitName, TraitCacheObjectValue)]
        public void get_object()
        {
            Cache.FlushAll();

            Cache.SetObject<BsUserDTO>(TheFirstUser, KeyBuilder);
            Cache.KeyExists<BsUserDTO>(TheFirstUser, KeyBuilder).Should().BeTrue();

            Cache.SetObject<BsUserDTO>(TheSecondUser, KeyBuilder);
            Cache.KeyExists<BsUserDTO>(TheSecondUser, KeyBuilder).Should().BeTrue();

            Cache.GetObject<BsUserDTO>(TheFirstUser, KeyBuilder).ShouldBeEquivalentTo(TheFirstUser);
            Cache.GetObject<BsUserDTO>(TheSecondUser, KeyBuilder).ShouldBeEquivalentTo(TheSecondUser);            
        }

        [Fact(DisplayName = "set_object_with_tags")]
        [Trait(TraitName, TraitCacheObjectValue)]
        public void set_object_with_tags()
        {
            Cache.FlushAll();

            Cache.SetObject<BsUserDTO>(TheFirstUser, KeyBuilder, TagsBuilder);
            Cache.KeyExists<BsUserDTO>(TheFirstUser, KeyBuilder).Should().BeTrue();

            Cache.SetObject<BsUserDTO>(TheSecondUser, KeyBuilder, TagsBuilder);
            Cache.KeyExists<BsUserDTO>(TheSecondUser, KeyBuilder).Should().BeTrue();

            var key_1 = KeyBuilder.Invoke(TheFirstUser).ToString();
            var key_2 = KeyBuilder.Invoke(TheSecondUser).ToString();

            Cache.GetRawKeysByTag<BsUserDTO>(TheFirstUser, TagsBuilder).Single().Should().Be(key_1);
            Cache.GetRawKeysByTag<BsUserDTO>(TheSecondUser, TagsBuilder).Single().Should().Be(key_2);
        }

        [Fact(DisplayName = "get_objects_by_tag")]
        [Trait(TraitName, TraitCacheObjectValue)]
        public void get_objects_by_tag()
        {
            Cache.FlushAll();

            Cache.SetObject<BsUserDTO>(TheFirstUser, KeyBuilder, TagsBuilder);
            Cache.SetObject<BsUserDTO>(TheSecondUser, KeyBuilder, TagsBuilder);

            Cache.KeyExists<BsUserDTO>(TheFirstUser, KeyBuilder).Should().BeTrue();
            Cache.KeyExists<BsUserDTO>(TheSecondUser, KeyBuilder).Should().BeTrue();
            
            Cache.GetObjectsByTag<BsUserDTO>(TheFirstUser, TagsBuilder).Single().ShouldBeEquivalentTo(TheFirstUser);            
        }

        [Fact(DisplayName = "remove_object_key")]
        [Trait(TraitName, TraitCacheObjectValue)]
        public void remove_object_key()
        {
            Cache.FlushAll();

            Cache.SetObject<BsUserDTO>(TheFirstUser, KeyBuilder);
            Cache.SetObject<BsUserDTO>(TheSecondUser, KeyBuilder);

            Cache.KeyExists<BsUserDTO>(TheFirstUser, KeyBuilder).Should().BeTrue();
            Cache.KeyExists<BsUserDTO>(TheSecondUser, KeyBuilder).Should().BeTrue();

            Cache.RemoveKey<BsUserDTO>(Users, KeyBuilder);

            Cache.KeyExists<BsUserDTO>(TheFirstUser, KeyBuilder).Should().BeFalse();
            Cache.KeyExists<BsUserDTO>(TheSecondUser, KeyBuilder).Should().BeFalse();
        }

        [Fact(DisplayName = "add_tags_to_object_key")]
        [Trait(TraitName, TraitCacheObjectValue)]
        public void add_tags_to_object_key()
        {
            Cache.FlushAll();

            Cache.SetObject<BsUserDTO>(TheFirstUser, KeyBuilder);
            Cache.SetObject<BsUserDTO>(TheSecondUser, KeyBuilder);

            Cache.KeyExists<BsUserDTO>(TheFirstUser, KeyBuilder).Should().BeTrue();
            Cache.KeyExists<BsUserDTO>(TheSecondUser, KeyBuilder).Should().BeTrue();

            Cache.AddTagsToKey<BsUserDTO>(TheFirstUser, TagsBuilder, KeyBuilder);
            Cache.AddTagsToKey<BsUserDTO>(TheSecondUser, TagsBuilder, KeyBuilder);

            var key_1 = TheFirstUser.Id.ToString();
            var key_2 = TheSecondUser.Id.ToString();

            Cache.GetRawKeysByTag<BsUserDTO>(TheFirstUser, TagsBuilder).Single().Should().Be(key_1);
            Cache.GetRawKeysByTag<BsUserDTO>(TheSecondUser, TagsBuilder).Single().Should().Be(key_2);
        }

        [Fact(DisplayName = "try_get_object")]
        [Trait(TraitName, TraitCacheObjectValue)]
        public void try_get_object()
        {
            Cache.FlushAll();

            Cache.SetObject<BsUserDTO>(TheFirstUser, KeyBuilder);
            Cache.SetObject<BsUserDTO>(TheSecondUser, KeyBuilder);
            
            BsUserDTO theFirstUser;
            BsUserDTO theSecondUser;

            Cache.TryGetObject<BsUserDTO>(TheFirstUser, KeyBuilder, out theFirstUser).Should().BeTrue();
            theFirstUser.ShouldBeEquivalentTo(TheFirstUser);

            Cache.TryGetObject<BsUserDTO>(TheSecondUser, KeyBuilder, out theSecondUser).Should().BeTrue();
            theSecondUser.ShouldBeEquivalentTo(TheSecondUser);
        }

        [Fact(DisplayName = "remove_tags_from_object_key")]
        [Trait(TraitName, TraitCacheObjectValue)]
        public void remove_tags_from_object_key()
        {
            Cache.FlushAll();

            Cache.SetObject<BsUserDTO>(TheFirstUser, KeyBuilder, TagsBuilder);
            Cache.SetObject<BsUserDTO>(TheSecondUser, KeyBuilder, TagsBuilder);

            Cache.KeyExists<BsUserDTO>(TheFirstUser, KeyBuilder).Should().BeTrue();
            Cache.KeyExists<BsUserDTO>(TheSecondUser, KeyBuilder).Should().BeTrue();

            Cache.RemoveTagsFromKey<BsUserDTO>(TheFirstUser, TagsBuilder, KeyBuilder);
            Cache.RemoveTagsFromKey<BsUserDTO>(TheSecondUser, TagsBuilder, KeyBuilder);

            var key = Cache.GetKey<BsUserDTO>(TheFirstUser);

            Cache.GetRawKeysByTag<BsUserDTO>(TheFirstUser, TagsBuilder).Should().NotContain(key);
        }        

        [Fact(DisplayName = "fetch_object_when_cache_hit")]
        [Trait(TraitName, TraitCacheObjectValue)]
        public void fetch_object_when_cache_hit()
        {
            Cache.FlushAll();

            Cache.SetObject<BsUserDTO>(TheFirstUser, KeyBuilder);
            Cache.SetObject<BsUserDTO>(TheSecondUser, KeyBuilder);

            int counter = 0;

            counter.Should().Be(0);

            Cache.FetchObject<BsUserDTO>(TheFirstUser, KeyBuilder, () => { counter++; return TheFirstUser; }).Should().NotBeNull();
            Cache.FetchObject<BsUserDTO>(TheSecondUser, KeyBuilder, () => { counter++; return TheSecondUser; }).Should().NotBeNull();

            counter.Should().Be(0);

            Cache.KeyExists<BsUserDTO>(TheFirstUser, KeyBuilder).Should().BeTrue();
            Cache.KeyExists<BsUserDTO>(TheSecondUser, KeyBuilder).Should().BeTrue();
        }

        [Fact(DisplayName = "fetch_object_when_cache_missing")]
        [Trait(TraitName, TraitCacheObjectValue)]
        public void fetch_object_when_cache_missing()
        {
            Cache.FlushAll();

            int counter = 0;       

            //The counter should be 0
            counter.Should().Be(0);

            //Fetch object when cache missing, The counter sould be 1
            Cache.FetchObject<BsUserDTO>(TheFirstUser, KeyBuilder, () => { counter++; return TheFirstUser; }).Should().NotBeNull();
            counter.Should().Be(1);

            //Fetch object again when cache hit, The counter sould be 1
            Cache.FetchObject<BsUserDTO>(TheFirstUser, KeyBuilder, () => { counter++; return TheFirstUser; }).Should().NotBeNull();
            counter.Should().Be(1);

            //Fetch the other object when cache missing, The counter sould be 2
            Cache.FetchObject<BsUserDTO>(TheSecondUser, KeyBuilder, () => { counter++; return TheSecondUser; }).Should().NotBeNull();
            counter.Should().Be(2);

            //Fetch the other object again when cache hit, The counter sould be 2
            Cache.FetchObject<BsUserDTO>(TheSecondUser, KeyBuilder, () => { counter++; return TheSecondUser; }).Should().NotBeNull();
            counter.Should().Be(2);

            Cache.KeyExists<BsUserDTO>(TheFirstUser, KeyBuilder).Should().BeTrue();
            Cache.KeyExists<BsUserDTO>(TheSecondUser, KeyBuilder).Should().BeTrue();

            Cache.GetObject<BsUserDTO>(TheFirstUser, KeyBuilder).ShouldBeEquivalentTo(TheFirstUser);
            Cache.GetObject<BsUserDTO>(TheSecondUser, KeyBuilder).ShouldBeEquivalentTo(TheSecondUser);
        }

        [Fact(DisplayName = "fetch_object_with_tags_builder_when_cache_hit")]
        [Trait(TraitName, TraitCacheObjectValue)]
        public void fetch_object_with_tags_builder_when_cache_hit()
        {
            Cache.FlushAll();
            
            int counter = 0;
            
            Cache.SetObject<BsUserDTO>(TheFirstUser, KeyBuilder);
            Cache.SetObject<BsUserDTO>(TheSecondUser, KeyBuilder);

            counter.Should().Be(0); 
            Cache.FetchObject<BsUserDTO>(TheFirstUser, KeyBuilder, () => { counter++; return TheFirstUser; }, TagsBuilder).Should().NotBeNull();
            counter.Should().Be(0);

            Cache.FetchObject<BsUserDTO>(TheSecondUser, KeyBuilder, () => { counter++; return TheSecondUser; }, TagsBuilder).Should().NotBeNull();
            counter.Should().Be(0);

            Cache.GetRawKeysByTag<BsUserDTO>(TheFirstUser, TagsBuilder).Should().BeEmpty();
            Cache.GetRawKeysByTag<BsUserDTO>(TheSecondUser, TagsBuilder).Should().BeEmpty();
        }

        [Fact(DisplayName = "fetch_object_with_tags_builder_when_cache_missing")]
        [Trait(TraitName, TraitCacheObjectValue)]
        public void fetch_object_with_tags_builder_when_cache_missing()
        {
            Cache.FlushAll();

            int counter = 0;

            counter.Should().Be(0);

            // Cache missing
            Cache.FetchObject<BsUserDTO>(TheFirstUser, KeyBuilder, () => { counter++; return TheFirstUser; }, TagsBuilder).Should().NotBeNull();
            counter.Should().Be(1);

            // Cache missing
            Cache.FetchObject<BsUserDTO>(TheSecondUser, KeyBuilder, () => { counter++; return TheSecondUser; }, TagsBuilder).Should().NotBeNull();
            counter.Should().Be(2);

            Cache.GetRawKeysByTag<BsUserDTO>(TheFirstUser, TagsBuilder).Should().Contain(TheFirstUser.Id.ToString());
            Cache.GetRawKeysByTag<BsUserDTO>(TheSecondUser, TagsBuilder).Should().Contain(TheSecondUser.Id.ToString());

            // Cache hit
            Cache.FetchObject<BsUserDTO>(TheFirstUser, KeyBuilder, () => { counter++; return TheFirstUser; }, TagsBuilder).Should().NotBeNull();
            counter.Should().Be(2);
        }
        #endregion

        #region Hashed cache testing
        [Fact(DisplayName = "set_hashed")]
        [Trait(TraitName, TraitCacheHashedValue)]
        public void set_hashed()
        {
            Cache.FlushAll();

            Cache.SetHashed<BsUserDTO>(Users, HashFieldBuilder);
            Cache.KeyExists<BsUserDTO>().Should().BeTrue();
        }

        [Fact(DisplayName = "set_hashed_with_tags")]
        [Trait(TraitName, TraitCacheHashedValue)]
        public void set_hashed_with_tags()
        {
            Cache.FlushAll();

            Cache.SetHashed<BsUserDTO>(TheFirstUser, HashFieldBuilder, TagsBuilder);
            Cache.SetHashed<BsUserDTO>(TheSecondUser, HashFieldBuilder, TagsBuilder);

            Cache.KeyExists<BsUserDTO>().Should().BeTrue();

            var key = Cache.GetKey<BsUserDTO>();

            Cache.GetRawKeysByTag<BsUserDTO>(TheFirstUser, TagsBuilder).Should().Contain(key);
        }

        [Fact(DisplayName = "get_hashed")]
        [Trait(TraitName, TraitCacheHashedValue)]
        public void get_hashed()
        {
            Cache.FlushAll();

            Cache.SetHashed<BsUserDTO>(Users, HashFieldBuilder);
            Cache.KeyExists<BsUserDTO>().Should().BeTrue();

            Cache.GetHashed<BsUserDTO>(TheFirstUser, HashFieldBuilder).Should().NotBeNull();
            Cache.GetHashed<BsUserDTO>(TheSecondUser, HashFieldBuilder).Should().NotBeNull();
        }

        [Fact(DisplayName = "get_hashed_by_tags")]
        [Trait(TraitName, TraitCacheHashedValue)]
        public void get_hashed_by_tags()
        {
            Cache.FlushAll();
            Cache.SetHashed<BsUserDTO>(TheFirstUser, HashFieldBuilder, TagsBuilder);
            Cache.SetHashed<BsUserDTO>(TheSecondUser, HashFieldBuilder, TagsBuilder);

            Cache.KeyExists<BsUserDTO>().Should().BeTrue();

            Cache.GetObjectsByTag<BsUserDTO>(TheFirstUser, TagsBuilder).FirstOrDefault().ShouldBeEquivalentTo(TheFirstUser);
            Cache.GetObjectsByTag<BsUserDTO>(TheSecondUser, TagsBuilder).FirstOrDefault().ShouldBeEquivalentTo(TheSecondUser);
        }

        [Fact(DisplayName = "remove_hash_field")]
        [Trait(TraitName, TraitCacheHashedValue)]
        public void remove_hash_field()
        {
            Cache.FlushAll();

            Cache.SetHashed<BsUserDTO>(Users, HashFieldBuilder);
            Cache.KeyExists<BsUserDTO>().Should().BeTrue();

            Cache.RemoveHashed<BsUserDTO>(TheFirstUser, HashFieldBuilder);
            Cache.RemoveHashed<BsUserDTO>(TheSecondUser, HashFieldBuilder);

            Cache.GetHashed<BsUserDTO>(TheFirstUser, HashFieldBuilder).Should().BeNull();
            Cache.GetHashed<BsUserDTO>(TheSecondUser, HashFieldBuilder).Should().BeNull();

            Cache.KeyExists<BsUserDTO>().Should().BeTrue();
        }

        [Fact(DisplayName = "remove_hashed_key")]
        [Trait(TraitName, TraitCacheHashedValue)]
        public void remove_hashed_key()
        {
            Cache.FlushAll();

            Cache.SetHashed<BsUserDTO>(Users, HashFieldBuilder);
            Cache.KeyExists<BsUserDTO>().Should().BeTrue();

            Cache.RemoveKey<BsUserDTO>();
            Cache.KeyExists<BsUserDTO>().Should().BeFalse();            
        }        

        [Fact(DisplayName = "set_hashed_with_ttl")]
        [Trait(TraitName, TraitCacheHashedValue)]
        public void set_hashed_with_ttl()
        {
            Cache.FlushAll();
         
            int counter = 0;
            double ms = 3;

            counter.Should().Be(0);
            Cache.SetHashed<BsUserDTO>(TheFirstUser, HashFieldBuilder, TagsBuilder, TimeSpan.FromSeconds(ms));
            Cache.FetchHashed<BsUserDTO>(TheFirstUser, HashFieldBuilder, () => { counter++; return TheFirstUser; }).Should().NotBeNull();
            counter.Should().Be(0);

            Cache.KeyExists<BsUserDTO>().Should().BeTrue();

            Thread.Sleep(TimeSpan.FromSeconds(ms + 0.5));
            Cache.KeyExists<BsUserDTO>().Should().BeFalse();

            Cache.FetchHashed<BsUserDTO>(TheFirstUser, HashFieldBuilder, () => { counter++; return TheFirstUser; }).Should().NotBeNull();
            
            counter.Should().Be(1);
            Cache.KeyExists<BsUserDTO>().Should().BeTrue();
        }

        [Fact(DisplayName = "add_tags_to_hashed_key")]
        [Trait(TraitName, TraitCacheHashedValue)]
        public void add_tags_to_hashed_key()
        {
            Cache.FlushAll();

            Cache.SetHashed<BsUserDTO>(TheFirstUser, HashFieldBuilder);
            Cache.SetHashed<BsUserDTO>(TheSecondUser, HashFieldBuilder);

            Cache.KeyExists<BsUserDTO>().Should().BeTrue();
            
            Cache.AddTagsToKey<BsUserDTO>(TheFirstUser, TagsBuilder);

            var key = Cache.GetKey<BsUserDTO>();

            Cache.GetRawKeysByTag<BsUserDTO>(TheFirstUser, TagsBuilder).Should().Contain(key);
            Cache.GetRawKeysByTag<BsUserDTO>(TheSecondUser, TagsBuilder).Should().BeEmpty();
        }

        [Fact(DisplayName = "add_tags_to_hash_field")]
        [Trait(TraitName, TraitCacheHashedValue)]
        public void add_tags_to_hash_field()
        {
            Cache.FlushAll();
            Cache.SetHashed<BsUserDTO>(TheFirstUser, HashFieldBuilder);
            Cache.SetHashed<BsUserDTO>(TheSecondUser, HashFieldBuilder);

            Cache.KeyExists<BsUserDTO>().Should().BeTrue();
            
            Cache.AddTagsToHashField<BsUserDTO>(TheFirstUser, HashFieldBuilder, TagsBuilder);
            Cache.AddTagsToHashField<BsUserDTO>(TheSecondUser, HashFieldBuilder, TagsBuilder);

            Cache.GetRawKeysByTag<BsUserDTO>(TheFirstUser, TagsBuilder);
            Cache.GetRawKeysByTag<BsUserDTO>(TheSecondUser, TagsBuilder);
        }

        [Fact(DisplayName = "try_get_hashed")]
        [Trait(TraitName, TraitCacheHashedValue)]
        public void try_get_hashed()
        {
            Cache.FlushAll();
            Cache.SetHashed<BsUserDTO>(TheFirstUser, HashFieldBuilder);
            Cache.SetHashed<BsUserDTO>(TheSecondUser, HashFieldBuilder);

            BsUserDTO theFirstUser;
            BsUserDTO theSecondUser;

            Cache.TryGetHashed<BsUserDTO>(TheFirstUser, HashFieldBuilder, out theFirstUser).Should().BeTrue();
            Cache.TryGetHashed<BsUserDTO>(TheSecondUser, HashFieldBuilder, out theSecondUser).Should().BeTrue();

            theFirstUser.ShouldBeEquivalentTo(TheFirstUser);
            theSecondUser.ShouldBeEquivalentTo(TheSecondUser);
        }

        [Fact(DisplayName = "remove_tags_from_hashed_key")]
        [Trait(TraitName, TraitCacheHashedValue)]
        public void remove_tags_from_hashed_key()
        {
            Cache.FlushAll();
            Cache.SetHashed<BsUserDTO>(TheFirstUser, HashFieldBuilder);
            Cache.SetHashed<BsUserDTO>(TheSecondUser, HashFieldBuilder);

            Cache.KeyExists<BsUserDTO>().Should().BeTrue();

            Cache.AddTagsToKey<BsUserDTO>(TheFirstUser, TagsBuilder);

            Cache.RemoveTagsFromKey<BsUserDTO>(TheFirstUser, TagsBuilder);
            var key = Cache.GetKey<BsUserDTO>(TheFirstUser);
            Cache.GetRawKeysByTag<BsUserDTO>(TheFirstUser, TagsBuilder).Should().NotContain(key);
        }

        [Fact(DisplayName = "remove_tags_from_hashe_Field")]
        [Trait(TraitName, TraitCacheHashedValue)]
        public void remove_tags_from_hashe_Field()
        {
            Cache.FlushAll();

            Cache.SetHashed<BsUserDTO>(TheFirstUser, HashFieldBuilder, TagsBuilder);
            Cache.SetHashed<BsUserDTO>(TheSecondUser, HashFieldBuilder, TagsBuilder);

            Cache.KeyExists<BsUserDTO>().Should().BeTrue();

            Cache.RemoveTagsFromHashField<BsUserDTO>(TheFirstUser, HashFieldBuilder, TagsBuilder);
            
            var tags_1 = Cache.GetTags<BsUserDTO>(TheFirstUser, TagsBuilder);
            var tags_2 = Cache.GetTags<BsUserDTO>(TheSecondUser, TagsBuilder);

            Cache.GetAllTags().Should().NotContain(tags_1);
            Cache.GetAllTags().Should().Contain(tags_2);
        }

        [Fact(DisplayName = "fetch_hashed_when_cache_hit")]
        [Trait(TraitName, TraitCacheHashedValue)]
        public void fetch_hashed_when_cache_hit()
        {
            Cache.FlushAll();

            Cache.SetHashed<BsUserDTO>(TheFirstUser, HashFieldBuilder);
            Cache.SetHashed<BsUserDTO>(TheSecondUser, HashFieldBuilder);

            int counter = 0;

            counter.Should().Be(0);

            Cache.FetchHashed<BsUserDTO>(TheFirstUser, HashFieldBuilder, () => { counter++; return TheFirstUser; }).Should().NotBeNull();
            
            counter.Should().Be(0);

            Cache.FetchHashed<BsUserDTO>(TheSecondUser, HashFieldBuilder, () => { counter++; return TheSecondUser; }).Should().NotBeNull();

            counter.Should().Be(0);

            Cache.KeyExists<BsUserDTO>().Should().BeTrue();
        }

        [Fact(DisplayName = "fetch_hashed_when_cache_missing")]
        [Trait(TraitName, TraitCacheHashedValue)]
        public void fetch_hashed_when_cache_missing()
        {
            Cache.FlushAll();

            int counter = 0;
           
            Cache.FlushAll();

            //The counter should be 0
            counter.Should().Be(0);

            //Fetch hashed when cache missing, The counter sould be 1
            Cache.FetchHashed<BsUserDTO>(TheFirstUser, HashFieldBuilder, () => { counter++; return TheFirstUser; }).Should().NotBeNull();
            counter.Should().Be(1);

            //Fetch hashed again when cache hit, The counter sould be 1
            Cache.FetchHashed<BsUserDTO>(TheFirstUser, HashFieldBuilder, () => { counter++; return TheFirstUser; }).Should().NotBeNull();
            counter.Should().Be(1);

            //Fetch the other object when cache missing, The counter sould be 2
            Cache.FetchHashed<BsUserDTO>(TheSecondUser, HashFieldBuilder, () => { counter++; return TheSecondUser; }).Should().NotBeNull();
            counter.Should().Be(2);

            //Fetch the other object again when cache hit, The counter sould be 2
            Cache.FetchHashed<BsUserDTO>(TheSecondUser, HashFieldBuilder, () => { counter++; return TheSecondUser; }).Should().NotBeNull();
            counter.Should().Be(2);

            Cache.KeyExists<BsUserDTO>().Should().BeTrue();

            Cache.GetHashed<BsUserDTO>(TheFirstUser, HashFieldBuilder).ShouldBeEquivalentTo(TheFirstUser);
            Cache.GetHashed<BsUserDTO>(TheSecondUser, HashFieldBuilder).ShouldBeEquivalentTo(TheSecondUser);
        }

        [Fact(DisplayName = "fetch_hashed_with_tags_builder_when_cache_hit")]
        [Trait(TraitName, TraitCacheHashedValue)]
        public void fetch_hashed_with_tags_builder_when_cache_hit()
        {
            Cache.FlushAll();

            int counter = 0;

            Cache.SetHashed<BsUserDTO>(TheFirstUser, HashFieldBuilder);
            Cache.SetHashed<BsUserDTO>(TheSecondUser, HashFieldBuilder);

            counter.Should().Be(0);
            Cache.FetchHashed<BsUserDTO>(TheFirstUser, HashFieldBuilder, () => { counter++; return TheFirstUser; }, TagsBuilder).Should().NotBeNull();
            counter.Should().Be(0);
            Cache.FetchHashed<BsUserDTO>(TheSecondUser, HashFieldBuilder, () => { counter++; return TheSecondUser; }, TagsBuilder).Should().NotBeNull();
            counter.Should().Be(0);
            
            Cache.KeyExists<BsUserDTO>().Should().BeTrue();

            Cache.GetRawKeysByTag<BsUserDTO>(TheFirstUser, TagsBuilder).Should().BeEmpty();
        }

        [Fact(DisplayName = "fetch_hashed_with_tags_builder_when_cache_missing")]
        [Trait(TraitName, TraitCacheHashedValue)]
        public void fetch_hashed_with_tags_builder_when_cache_missing()
        {
            Cache.FlushAll();

            int counter = 0;
            
            counter.Should().Be(0);
            var user1 = Cache.FetchHashed<BsUserDTO>(TheFirstUser, HashFieldBuilder, () => { counter++; return TheFirstUser; }, TagsBuilder).Should().NotBeNull();
            counter.Should().Be(1);
            var user2 = Cache.FetchHashed<BsUserDTO>(TheSecondUser, HashFieldBuilder, () => { counter++; return TheSecondUser; }, TagsBuilder).Should().NotBeNull();
            counter.Should().Be(2);

            Cache.KeyExists<BsUserDTO>().Should().BeTrue();

            var key = Cache.GetKey<BsUserDTO>();

            Cache.GetRawKeysByTag<BsUserDTO>(TheFirstUser, TagsBuilder).Should().Contain(key);
        }
        #endregion

        [Fact(DisplayName = "get_keys_by_pattern")]
        [Trait(TraitName, "Common")]
        public void get_keys_by_pattern()
        {
            Cache.FlushAll();

            Cache.SetHashed<BsUserDTO>(Users, HashFieldBuilder);
            Cache.SetObject<BsUserDTO>(TheFirstUser, KeyBuilder);
            Cache.SetObject<BsUserDTO>(TheSecondUser, KeyBuilder);

            string pattern = "BsUser:*";

            var keys = Cache.GetKeysByPattern(pattern);
            keys.Should().NotBeNullOrEmpty();

            var key_1 = Cache.GetKey<BsUserDTO>(TheFirstUser, KeyBuilder);
            var key_2 = Cache.GetKey<BsUserDTO>(TheSecondUser, KeyBuilder);
            var key_3 = Cache.GetKey<BsUserDTO>();            

            keys.Should().Contain(new string[] { key_1, key_2, key_3 });
        }

        [Fact(DisplayName = "key_expire")]
        [Trait(TraitName, "Common")]
        public void key_expire()
        {
            Cache.FlushAll();

            Cache.SetHashed<BsUserDTO>(Users, HashFieldBuilder);
            Cache.KeyExists<BsUserDTO>().Should().BeTrue();

            Cache.SetObject<BsUserDTO>(TheFirstUser, KeyBuilder);            
            Cache.KeyExists<BsUserDTO>(TheFirstUser, KeyBuilder).Should().BeTrue();

            double ms = 3;
            
            Cache.KeyExpire<BsUserDTO>(DateTime.Now.AddSeconds(ms));
            Cache.KeyExpire<BsUserDTO>(DateTime.Now.AddSeconds(ms), TheFirstUser, KeyBuilder);

            Thread.Sleep(TimeSpan.FromSeconds(ms + 0.5));

            Cache.KeyExists<BsUserDTO>().Should().BeFalse();
            Cache.KeyExists<BsUserDTO>(TheFirstUser, KeyBuilder).Should().BeFalse();
        }

        [Fact(DisplayName = "invalidate_keys_by_tags")]
        [Trait(TraitName, "Common")]
        public void invalidate_keys_by_tags()
        {
            Cache.FlushAll();

            Cache.SetHashed<BsUserDTO>(TheFirstUser, HashFieldBuilder, TagsBuilder);
            Cache.SetObject<BsUserDTO>(TheFirstUser, KeyBuilder, TagsBuilder);

            Cache.KeyExists<BsUserDTO>().Should().BeTrue();
            Cache.KeyExists<BsUserDTO>(TheFirstUser, KeyBuilder).Should().BeTrue();

            var tags = Cache.GetTags<BsUserDTO>(TheFirstUser, TagsBuilder);

            Cache.InvalidateKeysByTag(tags);

            Cache.KeyExists<BsUserDTO>().Should().BeFalse();
            Cache.KeyExists<BsUserDTO>(TheFirstUser, KeyBuilder).Should().BeFalse();                        
        }
    }
}