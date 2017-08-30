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
            Redis.Cache.FlushAll();

            Redis.Cache.SetObject<BsUserDTO>(TheFirstUser, KeyBuilder);
            Redis.Cache.KeyExists<BsUserDTO>(TheFirstUser, KeyBuilder).Should().BeTrue();

            Redis.Cache.SetObject<BsUserDTO>(TheSecondUser, KeyBuilder);
            Redis.Cache.KeyExists<BsUserDTO>(TheSecondUser, KeyBuilder).Should().BeTrue();
        }

        [Fact(DisplayName = "set_object_with_ttl")]
        [Trait(TraitName, TraitCacheObjectValue)]
        public void set_object_with_ttl()
        {
            Redis.Cache.FlushAll();

            double ms = 3;

            Redis.Cache.SetObject<BsUserDTO>(TheFirstUser, KeyBuilder, TimeSpan.FromSeconds(ms));
            Redis.Cache.KeyExists<BsUserDTO>(TheFirstUser, KeyBuilder).Should().BeTrue();

            Thread.Sleep(TimeSpan.FromSeconds(ms + 0.5));
            Redis.Cache.KeyExists<BsUserDTO>(TheFirstUser, KeyBuilder).Should().BeFalse();            
        }

        [Fact(DisplayName = "get_object")]
        [Trait(TraitName, TraitCacheObjectValue)]
        public void get_object()
        {
            Redis.Cache.FlushAll();

            Redis.Cache.SetObject<BsUserDTO>(TheFirstUser, KeyBuilder);
            Redis.Cache.KeyExists<BsUserDTO>(TheFirstUser, KeyBuilder).Should().BeTrue();

            Redis.Cache.SetObject<BsUserDTO>(TheSecondUser, KeyBuilder);
            Redis.Cache.KeyExists<BsUserDTO>(TheSecondUser, KeyBuilder).Should().BeTrue();

            var theFirstUser = Redis.Cache.GetObject<BsUserDTO>(TheFirstUser, KeyBuilder);
            theFirstUser.Should().NotBeNull();
            theFirstUser.Id.Should().Be(theFirstUser.Id);

            var theSecondUser = Redis.Cache.GetObject<BsUserDTO>(TheSecondUser, KeyBuilder);
            theSecondUser.Should().NotBeNull();
            theSecondUser.Id.Should().Be(theSecondUser.Id);            
        }

        [Fact(DisplayName = "set_object_with_tags")]
        [Trait(TraitName, TraitCacheObjectValue)]
        public void set_object_with_tags()
        {
            Redis.Cache.FlushAll();

            Redis.Cache.SetObject<BsUserDTO>(TheFirstUser, KeyBuilder, TagsBuilder);
            Redis.Cache.KeyExists<BsUserDTO>(TheFirstUser, KeyBuilder).Should().BeTrue();

            Redis.Cache.SetObject<BsUserDTO>(TheSecondUser, KeyBuilder, TagsBuilder);            
            Redis.Cache.KeyExists<BsUserDTO>(TheSecondUser, KeyBuilder).Should().BeTrue();
            
            //var key_1 = CacheProviderEx.GetKey<BsUserDTO>(TheFirstUser, KeyBuilder);
            //var key_2 = CacheProviderEx.GetKey<BsUserDTO>(TheSecondUser, KeyBuilder);
            
            Redis.Cache.GetKeysByTag<BsUserDTO>(TheFirstUser, TagsBuilder).Should().Contain(KeyBuilder.Invoke(TheFirstUser).ToString());
            Redis.Cache.GetKeysByTag<BsUserDTO>(TheSecondUser, TagsBuilder).Should().Contain(KeyBuilder.Invoke(TheSecondUser).ToString());
        }

        [Fact(DisplayName = "get_objects_by_tag")]
        [Trait(TraitName, TraitCacheObjectValue)]
        public void get_objects_by_tag()
        {
            Redis.Cache.FlushAll();

            Redis.Cache.SetObject<BsUserDTO>(TheFirstUser, KeyBuilder, TagsBuilder);
            Redis.Cache.SetObject<BsUserDTO>(TheSecondUser, KeyBuilder, TagsBuilder);

            Redis.Cache.KeyExists<BsUserDTO>(TheFirstUser, KeyBuilder).Should().BeTrue();
            Redis.Cache.KeyExists<BsUserDTO>(TheSecondUser, KeyBuilder).Should().BeTrue();

            var objects = Redis.Cache.GetObjectsByTag<BsUserDTO>(TheFirstUser, TagsBuilder);
            objects.Should().NotBeNullOrEmpty();

            var keys = objects.Select(x => x.Id.ToString());
            keys.Should().NotBeNullOrEmpty();
            keys.Should().Contain(KeyBuilder.Invoke(TheFirstUser).ToString());
        }

        [Fact(DisplayName = "remove_object_key")]
        [Trait(TraitName, TraitCacheObjectValue)]
        public void remove_object_key()
        {
            Redis.Cache.FlushAll();

            Redis.Cache.SetObject<BsUserDTO>(TheFirstUser, KeyBuilder);
            Redis.Cache.SetObject<BsUserDTO>(TheSecondUser, KeyBuilder);

            Redis.Cache.KeyExists<BsUserDTO>(TheFirstUser, KeyBuilder).Should().BeTrue();
            Redis.Cache.KeyExists<BsUserDTO>(TheSecondUser, KeyBuilder).Should().BeTrue();

            Redis.Cache.RemoveKey<BsUserDTO>(Users, KeyBuilder);

            Redis.Cache.KeyExists<BsUserDTO>(TheFirstUser, KeyBuilder).Should().BeFalse();
            Redis.Cache.KeyExists<BsUserDTO>(TheSecondUser, KeyBuilder).Should().BeFalse();
        }

        [Fact(DisplayName = "add_tags_to_object_key")]
        [Trait(TraitName, TraitCacheObjectValue)]
        public void add_tags_to_object_key()
        {
            Redis.Cache.FlushAll();

            Redis.Cache.SetObject<BsUserDTO>(TheFirstUser, KeyBuilder);
            Redis.Cache.SetObject<BsUserDTO>(TheSecondUser, KeyBuilder);

            Redis.Cache.KeyExists<BsUserDTO>(TheFirstUser, KeyBuilder).Should().BeTrue();
            Redis.Cache.KeyExists<BsUserDTO>(TheSecondUser, KeyBuilder).Should().BeTrue();

            Redis.Cache.AddTagsToKey<BsUserDTO>(TheFirstUser, TagsBuilder, KeyBuilder);
            Redis.Cache.AddTagsToKey<BsUserDTO>(TheSecondUser, TagsBuilder, KeyBuilder);

            Redis.Cache.GetKeysByTag<BsUserDTO>(TheFirstUser, TagsBuilder).Should().Contain(KeyBuilder.Invoke(TheFirstUser).ToString());
            Redis.Cache.GetKeysByTag<BsUserDTO>(TheSecondUser, TagsBuilder).Should().Contain(KeyBuilder.Invoke(TheSecondUser).ToString());
        }

        [Fact(DisplayName = "try_get_object")]
        [Trait(TraitName, TraitCacheObjectValue)]
        public void try_get_object()
        {
            Redis.Cache.FlushAll();

            Redis.Cache.SetObject<BsUserDTO>(TheFirstUser, KeyBuilder);
            Redis.Cache.SetObject<BsUserDTO>(TheSecondUser, KeyBuilder);
            
            BsUserDTO theFirstUser;
            BsUserDTO theSecondUser;

            Redis.Cache.TryGetObject<BsUserDTO>(TheFirstUser, KeyBuilder, out theFirstUser).Should().BeTrue();
            theFirstUser.Should().NotBeNull();
            theFirstUser.Id.Should().Be(TheFirstUser.Id);

            Redis.Cache.TryGetObject<BsUserDTO>(TheSecondUser, KeyBuilder, out theSecondUser).Should().BeTrue();
            theSecondUser.Should().NotBeNull();
            theSecondUser.Id.Should().Be(TheSecondUser.Id);
        }

        [Fact(DisplayName = "remove_tags_from_object_key")]
        [Trait(TraitName, TraitCacheObjectValue)]
        public void remove_tags_from_object_key()
        {
            Redis.Cache.FlushAll();

            Redis.Cache.SetObject<BsUserDTO>(TheFirstUser, KeyBuilder, TagsBuilder);
            Redis.Cache.SetObject<BsUserDTO>(TheSecondUser, KeyBuilder, TagsBuilder);

            Redis.Cache.KeyExists<BsUserDTO>(TheFirstUser, KeyBuilder).Should().BeTrue();
            Redis.Cache.KeyExists<BsUserDTO>(TheSecondUser, KeyBuilder).Should().BeTrue();

            Redis.Cache.RemoveTagsFromKey<BsUserDTO>(TheFirstUser, TagsBuilder, KeyBuilder);
            Redis.Cache.RemoveTagsFromKey<BsUserDTO>(TheSecondUser, TagsBuilder, KeyBuilder);
            
            var tags = CacheProviderEx.GetTags<BsUserDTO>(TheFirstUser, TagsBuilder)
               .Union(CacheProviderEx.GetTags<BsUserDTO>(TheSecondUser, TagsBuilder)).ToArray();

            var keys = Redis.Cache.GetKeysByTag<BsUserDTO>(TheFirstUser, TagsBuilder);
            keys.Should().BeNullOrEmpty();
            keys.Should().NotContain(KeyBuilder.Invoke(TheFirstUser).ToString());
        }        

        [Fact(DisplayName = "fetch_object_when_cache_hit")]
        [Trait(TraitName, TraitCacheObjectValue)]
        public void fetch_object_when_cache_hit()
        {
            Redis.Cache.FlushAll();

            Redis.Cache.SetObject<BsUserDTO>(TheFirstUser, KeyBuilder);
            Redis.Cache.SetObject<BsUserDTO>(TheSecondUser, KeyBuilder);

            int counter = 0;

            counter.Should().Be(0);

            Redis.Cache.FetchObject<BsUserDTO>(TheFirstUser, KeyBuilder, () => { counter++; return TheFirstUser; }).Should().NotBeNull();
            Redis.Cache.FetchObject<BsUserDTO>(TheSecondUser, KeyBuilder, () => { counter++; return TheSecondUser; }).Should().NotBeNull();

            counter.Should().Be(0);

            Redis.Cache.KeyExists<BsUserDTO>(TheFirstUser, KeyBuilder).Should().BeTrue();
            Redis.Cache.KeyExists<BsUserDTO>(TheSecondUser, KeyBuilder).Should().BeTrue();
        }

        [Fact(DisplayName = "fetch_object_when_cache_missing")]
        [Trait(TraitName, TraitCacheObjectValue)]
        public void fetch_object_when_cache_missing()
        {
            Redis.Cache.FlushAll();

            int counter = 0;       

            //The counter should be 0
            counter.Should().Be(0);

            //Fetch object when cache missing, The counter sould be 1
            Redis.Cache.FetchObject<BsUserDTO>(TheFirstUser, KeyBuilder, () => { counter++; return TheFirstUser; }).Should().NotBeNull();
            counter.Should().Be(1);

            //Fetch object again when cache hit, The counter sould be 1
            Redis.Cache.FetchObject<BsUserDTO>(TheFirstUser, KeyBuilder, () => { counter++; return TheFirstUser; }).Should().NotBeNull();
            counter.Should().Be(1);

            //Fetch the other object when cache missing, The counter sould be 2
            Redis.Cache.FetchObject<BsUserDTO>(TheSecondUser, KeyBuilder, () => { counter++; return TheSecondUser; }).Should().NotBeNull();
            counter.Should().Be(2);

            //Fetch the other object again when cache hit, The counter sould be 2
            Redis.Cache.FetchObject<BsUserDTO>(TheSecondUser, KeyBuilder, () => { counter++; return TheSecondUser; }).Should().NotBeNull();
            counter.Should().Be(2);

            Redis.Cache.KeyExists<BsUserDTO>(TheFirstUser, KeyBuilder).Should().BeTrue();
            Redis.Cache.KeyExists<BsUserDTO>(TheSecondUser, KeyBuilder).Should().BeTrue();

            Redis.Cache.GetObject<BsUserDTO>(TheFirstUser, KeyBuilder).Id.Should().Be(TheFirstUser.Id);
            Redis.Cache.GetObject<BsUserDTO>(TheSecondUser, KeyBuilder).Id.Should().Be(TheSecondUser.Id);
        }

        [Fact(DisplayName = "fetch_object_with_tags_builder_when_cache_hit")]
        [Trait(TraitName, TraitCacheObjectValue)]
        public void fetch_object_with_tags_builder_when_cache_hit()
        {
            Redis.Cache.FlushAll();
            
            int counter = 0;
            
            Redis.Cache.SetObject<BsUserDTO>(TheFirstUser, KeyBuilder);
            Redis.Cache.SetObject<BsUserDTO>(TheSecondUser, KeyBuilder);

            counter.Should().Be(0); 
            Redis.Cache.FetchObject<BsUserDTO>(TheFirstUser, KeyBuilder, () => { counter++; return TheFirstUser; }, TagsBuilder).Should().NotBeNull();
            counter.Should().Be(0);

            Redis.Cache.FetchObject<BsUserDTO>(TheSecondUser, KeyBuilder, () => { counter++; return TheSecondUser; }, TagsBuilder).Should().NotBeNull();
            counter.Should().Be(0);

            Redis.Cache.GetKeysByTag<BsUserDTO>(TheFirstUser, TagsBuilder).Should().BeEmpty();
            Redis.Cache.GetKeysByTag<BsUserDTO>(TheSecondUser, TagsBuilder).Should().BeEmpty();
        }

        [Fact(DisplayName = "fetch_object_with_tags_builder_when_cache_missing")]
        [Trait(TraitName, TraitCacheObjectValue)]
        public void fetch_object_with_tags_builder_when_cache_missing()
        {
            Redis.Cache.FlushAll();

            int counter = 0;

            counter.Should().Be(0);

            // Cache missing
            Redis.Cache.FetchObject<BsUserDTO>(TheFirstUser, KeyBuilder, () => { counter++; return TheFirstUser; }, TagsBuilder).Should().NotBeNull();
            counter.Should().Be(1);

            // Cache missing
            Redis.Cache.FetchObject<BsUserDTO>(TheSecondUser, KeyBuilder, () => { counter++; return TheSecondUser; }, TagsBuilder).Should().NotBeNull();
            counter.Should().Be(2);

            Redis.Cache.GetKeysByTag<BsUserDTO>(TheFirstUser, TagsBuilder).Should().Contain(TheFirstUser.Id.ToString());
            Redis.Cache.GetKeysByTag<BsUserDTO>(TheSecondUser, TagsBuilder).Should().Contain(TheSecondUser.Id.ToString());

            // Cache hit
            Redis.Cache.FetchObject<BsUserDTO>(TheFirstUser, KeyBuilder, () => { counter++; return TheFirstUser; }, TagsBuilder).Should().NotBeNull();
            counter.Should().Be(2);
        }
        #endregion

        #region Hashed cache testing
        [Fact(DisplayName = "set_hashed")]
        [Trait(TraitName, TraitCacheHashedValue)]
        public void set_hashed()
        {
            Redis.Cache.FlushAll();

            Redis.Cache.SetHashed<BsUserDTO>(Users, HashFieldBuilder);
            Redis.Cache.KeyExists<BsUserDTO>().Should().BeTrue();
        }

        [Fact(DisplayName = "set_hashed_with_tags")]
        [Trait(TraitName, TraitCacheHashedValue)]
        public void set_hashed_with_tags()
        {
            Redis.Cache.FlushAll();

            Redis.Cache.SetHashed<BsUserDTO>(TheFirstUser, HashFieldBuilder, TagsBuilder);
            Redis.Cache.SetHashed<BsUserDTO>(TheSecondUser, HashFieldBuilder, TagsBuilder);

            Redis.Cache.KeyExists<BsUserDTO>().Should().BeTrue();
            
            var key = CacheProviderEx.GetKey<BsUserDTO>();

            Redis.Cache.GetKeysByTag<BsUserDTO>(TheFirstUser, TagsBuilder).Should().Contain(key);
        }

        [Fact(DisplayName = "get_hashed")]
        [Trait(TraitName, TraitCacheHashedValue)]
        public void get_hashed()
        {
            Redis.Cache.FlushAll();

            Redis.Cache.SetHashed<BsUserDTO>(Users, HashFieldBuilder);
            Redis.Cache.KeyExists<BsUserDTO>().Should().BeTrue();

            Redis.Cache.GetHashed<BsUserDTO>(TheFirstUser, HashFieldBuilder).Should().NotBeNull();
            Redis.Cache.GetHashed<BsUserDTO>(TheSecondUser, HashFieldBuilder).Should().NotBeNull();
        }

        [Fact(DisplayName = "get_hashed_by_tags")]
        [Trait(TraitName, TraitCacheHashedValue)]
        public void get_hashed_by_tags()
        {
            Redis.Cache.FlushAll();
            Redis.Cache.SetHashed<BsUserDTO>(TheFirstUser, HashFieldBuilder, TagsBuilder);
            Redis.Cache.SetHashed<BsUserDTO>(TheSecondUser, HashFieldBuilder, TagsBuilder);

            Redis.Cache.KeyExists<BsUserDTO>().Should().BeTrue();
           
            Redis.Cache.GetObjectsByTag<BsUserDTO>(TheFirstUser, TagsBuilder).Select(x => x.Id).Should().Contain(TheFirstUser.Id);
            Redis.Cache.GetObjectsByTag<BsUserDTO>(TheSecondUser, TagsBuilder).Select(x => x.Id).Should().Contain(TheSecondUser.Id);
        }

        [Fact(DisplayName = "remove_hash_field")]
        [Trait(TraitName, TraitCacheHashedValue)]
        public void remove_hash_field()
        {
            Redis.Cache.FlushAll();

            Redis.Cache.SetHashed<BsUserDTO>(Users, HashFieldBuilder);
            Redis.Cache.KeyExists<BsUserDTO>().Should().BeTrue();

            Redis.Cache.RemoveHashed<BsUserDTO>(TheFirstUser, HashFieldBuilder);
            Redis.Cache.RemoveHashed<BsUserDTO>(TheSecondUser, HashFieldBuilder);

            Redis.Cache.GetHashed<BsUserDTO>(TheFirstUser, HashFieldBuilder).Should().BeNull();
            Redis.Cache.GetHashed<BsUserDTO>(TheSecondUser, HashFieldBuilder).Should().BeNull();

            Redis.Cache.KeyExists<BsUserDTO>().Should().BeTrue();
        }

        [Fact(DisplayName = "remove_hashed_key")]
        [Trait(TraitName, TraitCacheHashedValue)]
        public void remove_hashed_key()
        {
            Redis.Cache.FlushAll();

            Redis.Cache.SetHashed<BsUserDTO>(Users, HashFieldBuilder);
            Redis.Cache.KeyExists<BsUserDTO>().Should().BeTrue();

            Redis.Cache.RemoveKey<BsUserDTO>();

            Redis.Cache.KeyExists<BsUserDTO>().Should().BeFalse();            
        }        

        [Fact(DisplayName = "set_hashed_with_ttl")]
        [Trait(TraitName, TraitCacheHashedValue)]
        public void set_hashed_with_ttl()
        {
            Redis.Cache.FlushAll();
         
            int counter = 0;
            double ms = 3;

            counter.Should().Be(0);
            Redis.Cache.SetHashed<BsUserDTO>(TheFirstUser, HashFieldBuilder, TagsBuilder, TimeSpan.FromSeconds(ms));
            Redis.Cache.FetchHashed<BsUserDTO>(TheFirstUser, HashFieldBuilder, () => { counter++; return TheFirstUser; }).Should().NotBeNull();
            counter.Should().Be(0);

            Redis.Cache.KeyExists<BsUserDTO>().Should().BeTrue();

            Thread.Sleep(TimeSpan.FromSeconds(ms + 0.5));
            Redis.Cache.KeyExists<BsUserDTO>().Should().BeFalse();

            Redis.Cache.FetchHashed<BsUserDTO>(TheFirstUser, HashFieldBuilder, () => { counter++; return TheFirstUser; }).Should().NotBeNull();
            
            counter.Should().Be(1);
            Redis.Cache.KeyExists<BsUserDTO>().Should().BeTrue();
        }

        [Fact(DisplayName = "add_tags_to_hashed_key")]
        [Trait(TraitName, TraitCacheHashedValue)]
        public void add_tags_to_hashed_key()
        {
            Redis.Cache.FlushAll();

            Redis.Cache.SetHashed<BsUserDTO>(TheFirstUser, HashFieldBuilder);
            Redis.Cache.SetHashed<BsUserDTO>(TheSecondUser, HashFieldBuilder);

            Redis.Cache.KeyExists<BsUserDTO>().Should().BeTrue();
            
            Redis.Cache.AddTagsToKey<BsUserDTO>(TheFirstUser, TagsBuilder);
            
            var key = CacheProviderEx.GetKey<BsUserDTO>();

            Redis.Cache.GetKeysByTag<BsUserDTO>(TheFirstUser, TagsBuilder).Should().Contain(key);
            Redis.Cache.GetKeysByTag<BsUserDTO>(TheSecondUser, TagsBuilder).Should().BeEmpty();
        }

        [Fact(DisplayName = "add_tags_to_hash_field")]
        [Trait(TraitName, TraitCacheHashedValue)]
        public void add_tags_to_hash_field()
        {
            Redis.Cache.FlushAll();
            Redis.Cache.SetHashed<BsUserDTO>(TheFirstUser, HashFieldBuilder);
            Redis.Cache.SetHashed<BsUserDTO>(TheSecondUser, HashFieldBuilder);

            Redis.Cache.KeyExists<BsUserDTO>().Should().BeTrue();
            
            Redis.Cache.AddTagsToHashField<BsUserDTO>(TheFirstUser, HashFieldBuilder, TagsBuilder);
            Redis.Cache.AddTagsToHashField<BsUserDTO>(TheSecondUser, HashFieldBuilder, TagsBuilder);

            Redis.Cache.GetKeysByTag<BsUserDTO>(TheFirstUser, TagsBuilder);
            Redis.Cache.GetKeysByTag<BsUserDTO>(TheSecondUser, TagsBuilder);
        }

        [Fact(DisplayName = "try_get_hashed")]
        [Trait(TraitName, TraitCacheHashedValue)]
        public void try_get_hashed()
        {
            Redis.Cache.FlushAll();
            Redis.Cache.SetHashed<BsUserDTO>(TheFirstUser, HashFieldBuilder);
            Redis.Cache.SetHashed<BsUserDTO>(TheSecondUser, HashFieldBuilder);

            BsUserDTO theFirstUser;
            BsUserDTO theSecondUser;

            Redis.Cache.TryGetHashed<BsUserDTO>(TheFirstUser, HashFieldBuilder, out theFirstUser).Should().BeTrue();
            Redis.Cache.TryGetHashed<BsUserDTO>(TheSecondUser, HashFieldBuilder, out theSecondUser).Should().BeTrue();
            theFirstUser.Should().NotBeNull();
            theFirstUser.Id.Should().Be(TheFirstUser.Id);
            theSecondUser.Should().NotBeNull();
            theSecondUser.Id.Should().Be(TheSecondUser.Id);
        }

        [Fact(DisplayName = "remove_tags_from_hashed_key")]
        [Trait(TraitName, TraitCacheHashedValue)]
        public void remove_tags_from_hashed_key()
        {
            Redis.Cache.FlushAll();
            Redis.Cache.SetHashed<BsUserDTO>(TheFirstUser, HashFieldBuilder, TagsBuilder);
            Redis.Cache.SetHashed<BsUserDTO>(TheSecondUser, HashFieldBuilder, TagsBuilder);

            Redis.Cache.KeyExists<BsUserDTO>().Should().BeTrue();

            Redis.Cache.RemoveTagsFromKey<BsUserDTO>(TheFirstUser, TagsBuilder);

            Redis.Cache.GetKeysByTag<BsUserDTO>(TheFirstUser, TagsBuilder).Should().NotContain(KeyBuilder.Invoke(TheFirstUser).ToString());
        }

        [Fact(DisplayName = "fetch_hashed_when_cache_hit")]
        [Trait(TraitName, TraitCacheHashedValue)]
        public void fetch_hashed_when_cache_hit()
        {
            Redis.Cache.FlushAll();

            Redis.Cache.SetHashed<BsUserDTO>(TheFirstUser, HashFieldBuilder);
            Redis.Cache.SetHashed<BsUserDTO>(TheSecondUser, HashFieldBuilder);

            int counter = 0;

            counter.Should().Be(0);

            Redis.Cache.FetchHashed<BsUserDTO>(TheFirstUser, HashFieldBuilder, () => { counter++; return TheFirstUser; }).Should().NotBeNull();
            
            counter.Should().Be(0);

            Redis.Cache.FetchHashed<BsUserDTO>(TheSecondUser, HashFieldBuilder, () => { counter++; return TheSecondUser; }).Should().NotBeNull();

            counter.Should().Be(0);

            Redis.Cache.KeyExists<BsUserDTO>().Should().BeTrue();
        }

        [Fact(DisplayName = "fetch_hashed_when_cache_missing")]
        [Trait(TraitName, TraitCacheHashedValue)]
        public void fetch_hashed_when_cache_missing()
        {
            Redis.Cache.FlushAll();

            int counter = 0;
           
            Redis.Cache.FlushAll();

            //The counter should be 0
            counter.Should().Be(0);

            //Fetch hashed when cache missing, The counter sould be 1
            Redis.Cache.FetchHashed<BsUserDTO>(TheFirstUser, HashFieldBuilder, () => { counter++; return TheFirstUser; }).Should().NotBeNull();
            counter.Should().Be(1);

            //Fetch hashed again when cache hit, The counter sould be 1
            Redis.Cache.FetchHashed<BsUserDTO>(TheFirstUser, HashFieldBuilder, () => { counter++; return TheFirstUser; }).Should().NotBeNull();
            counter.Should().Be(1);

            //Fetch the other object when cache missing, The counter sould be 2
            Redis.Cache.FetchHashed<BsUserDTO>(TheSecondUser, HashFieldBuilder, () => { counter++; return TheSecondUser; }).Should().NotBeNull();
            counter.Should().Be(2);

            //Fetch the other object again when cache hit, The counter sould be 2
            Redis.Cache.FetchHashed<BsUserDTO>(TheSecondUser, HashFieldBuilder, () => { counter++; return TheSecondUser; }).Should().NotBeNull();
            counter.Should().Be(2);

            Redis.Cache.KeyExists<BsUserDTO>().Should().BeTrue();

            Redis.Cache.GetHashed<BsUserDTO>(TheFirstUser, HashFieldBuilder).Id.Should().Be(TheFirstUser.Id);
            Redis.Cache.GetHashed<BsUserDTO>(TheSecondUser, HashFieldBuilder).Id.Should().Be(TheSecondUser.Id);
        }

        [Fact(DisplayName = "fetch_hashed_with_tags_builder_when_cache_hit")]
        [Trait(TraitName, TraitCacheHashedValue)]
        public void fetch_hashed_with_tags_builder_when_cache_hit()
        {
            Redis.Cache.FlushAll();

            int counter = 0;

            Redis.Cache.SetHashed<BsUserDTO>(TheFirstUser, HashFieldBuilder);
            Redis.Cache.SetHashed<BsUserDTO>(TheSecondUser, HashFieldBuilder);

            counter.Should().Be(0);
            Redis.Cache.FetchHashed<BsUserDTO>(TheFirstUser, HashFieldBuilder, () => { counter++; return TheFirstUser; }, TagsBuilder).Should().NotBeNull();
            counter.Should().Be(0);
            Redis.Cache.FetchHashed<BsUserDTO>(TheSecondUser, HashFieldBuilder, () => { counter++; return TheSecondUser; }, TagsBuilder).Should().NotBeNull();
            counter.Should().Be(0);
            
            Redis.Cache.KeyExists<BsUserDTO>().Should().BeTrue();

            Redis.Cache.GetKeysByTag<BsUserDTO>(TheFirstUser, TagsBuilder).Should().BeEmpty();
        }

        [Fact(DisplayName = "fetch_hashed_with_tags_builder_when_cache_missing")]
        [Trait(TraitName, TraitCacheHashedValue)]
        public void fetch_hashed_with_tags_builder_when_cache_missing()
        {
            Redis.Cache.FlushAll();

            int counter = 0;
            
            counter.Should().Be(0);
            var user1 = Redis.Cache.FetchHashed<BsUserDTO>(TheFirstUser, HashFieldBuilder, () => { counter++; return TheFirstUser; }, TagsBuilder).Should().NotBeNull();
            counter.Should().Be(1);
            var user2 = Redis.Cache.FetchHashed<BsUserDTO>(TheSecondUser, HashFieldBuilder, () => { counter++; return TheSecondUser; }, TagsBuilder).Should().NotBeNull();
            counter.Should().Be(2);

            Redis.Cache.KeyExists<BsUserDTO>().Should().BeTrue();

            var key = CacheProviderEx.GetKey<BsUserDTO>();

            Redis.Cache.GetKeysByTag<BsUserDTO>(TheFirstUser, TagsBuilder).Should().Contain(key);
        }
        #endregion

        [Fact(DisplayName = "get_keys_by_pattern")]
        [Trait(TraitName, "Common")]
        public void get_keys_by_pattern()
        {
            Redis.Cache.FlushAll();

            Redis.Cache.SetHashed<BsUserDTO>(Users, HashFieldBuilder);
            Redis.Cache.SetObject<BsUserDTO>(TheFirstUser, KeyBuilder);
            Redis.Cache.SetObject<BsUserDTO>(TheSecondUser, KeyBuilder);

            string pattern = "BsUser:*";

            var keys = Redis.Cache.GetKeysByPattern(pattern);
            var key_1 = CacheProviderEx.GetKey<BsUserDTO>(TheFirstUser, KeyBuilder);
            var key_2 = CacheProviderEx.GetKey<BsUserDTO>(TheSecondUser, KeyBuilder);
            var key_3 = CacheProviderEx.GetKey<BsUserDTO>();
            keys.Should().NotBeNullOrEmpty();

            keys.Should().Contain(new string[] { key_1, key_2, key_3 });
        }

        [Fact(DisplayName = "key_expire")]
        [Trait(TraitName, "Common")]
        public void key_expire()
        {
            Redis.Cache.FlushAll();

            Redis.Cache.SetHashed<BsUserDTO>(Users, HashFieldBuilder);
            Redis.Cache.SetObject<BsUserDTO>(TheFirstUser, KeyBuilder);

            Redis.Cache.KeyExists<BsUserDTO>().Should().BeTrue();
            Redis.Cache.KeyExists<BsUserDTO>(TheFirstUser, KeyBuilder).Should().BeTrue();
            double ms = 3;
            Redis.Cache.KeyExpire<BsUserDTO>(DateTime.Now.AddSeconds(ms));
            Redis.Cache.KeyExpire<BsUserDTO>(DateTime.Now.AddSeconds(ms), TheFirstUser, KeyBuilder);

            Thread.Sleep(TimeSpan.FromSeconds(ms + 0.5));

            Redis.Cache.KeyExists<BsUserDTO>().Should().BeFalse();
            Redis.Cache.KeyExists<BsUserDTO>(TheFirstUser, KeyBuilder).Should().BeFalse();
        }

        [Fact(DisplayName = "invalidate_keys_by_tag")]
        [Trait(TraitName, "Common")]
        public void invalidate_keys_by_tag()
        {
            Redis.Cache.FlushAll();

            Redis.Cache.SetHashed<BsUserDTO>(TheFirstUser, HashFieldBuilder, TagsBuilder);
            Redis.Cache.SetObject<BsUserDTO>(TheFirstUser, KeyBuilder, TagsBuilder);

            Redis.Cache.KeyExists<BsUserDTO>().Should().BeTrue();
            Redis.Cache.KeyExists<BsUserDTO>(TheFirstUser, KeyBuilder).Should().BeTrue();

            var tags = CacheProviderEx.GetTags<BsUserDTO>(TheFirstUser, TagsBuilder);

            Redis.Cache.InvalidateKeysByTag(tags);

            Redis.Cache.KeyExists<BsUserDTO>().Should().BeFalse();
            Redis.Cache.KeyExists<BsUserDTO>(TheFirstUser, KeyBuilder).Should().BeFalse();                        
        }
    }
}