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

namespace HisPlus.UnitTesting.Redis
{
    public partial class RedisCacheUnitTests : RedisTestBase, IClassFixture<RedisTestFixture>
    {
        #region private constant(s)
        private const string TraitName = "RedisCacheUnitTests";
        private const string TraitCacheObjectValue = "Object";
        private const string TraitCacheHashedValue = "Hashed";
        #endregion

        static Func<BsUserDTO, string> KeyBuilder = (x) => 
        {
            return string.Format("{0}:{1}", x.GetKey(), x.Id);
        };

        static Func<BsUserDTO, string> HashFieldBuilder = (x) =>
        {
            return string.Format("{0}:ID:{1}", x.GetKey(), x.Id);
        };

        Func<BsUserDTO[], string[]> KeysBuilder = (x) => 
        {
            string[] keys = new string[x.Length];

            for (int i = 0; i < x.Length; i++)
            {
                keys[i] = KeyBuilder.Invoke(x[i]);
            }

            return keys;
        };

        Func<string, string> HashKeyBuilder = (x) =>
        {
            return string.Format("{0}:{1}", x, "HASH");;
        };

        Func<BsUserDTO, string[]> TagsBuilder = (x) => 
        {
            return new string[]
            { 
                string.Format("{0}:{1}:{2}", x.GetKey(), "Name", x.Name), 
                string.Format("{0}:{1}:{2}", x.GetKey(), "Mobile", x.Mobile) 
            };
        };        
        
        Func<BsUserDTO[], IDictionary<string, BsUserDTO>> HashFieldsBuilder = (x =>
        {
            IDictionary<string, BsUserDTO> fieldValues = new Dictionary<string, BsUserDTO>();
            for (int i = 0; i < x.Length; i++)
            {
                fieldValues.Add(HashFieldBuilder.Invoke(x[i]), x[i]);
            }

            return fieldValues;
        });

        public RedisCacheUnitTests()
        {
            UserTags = TagsBuilder.Invoke(TheFirstUser).Union(TagsBuilder.Invoke(TheSecondUser)).ToArray();
        }

        #region Object cache testing
        [Fact(DisplayName = "SetObject_OK")]
        [Trait(TraitName, TraitCacheObjectValue)]
        public void SetObject_OK()
        {
            Redis.Cache.RemoveKey<BsUserDTO>(Users, KeysBuilder);

            Redis.Cache.KeyExists<BsUserDTO>(TheFirstUser, KeyBuilder).Should().BeFalse();
            Redis.Cache.KeyExists<BsUserDTO>(TheSecondUser, KeyBuilder).Should().BeFalse();

            Redis.Cache.SetObject<BsUserDTO>(TheFirstUser, KeyBuilder);
            Redis.Cache.SetObject<BsUserDTO>(TheSecondUser, KeyBuilder);

            Redis.Cache.KeyExists<BsUserDTO>(TheFirstUser, KeyBuilder).Should().BeTrue();
            Redis.Cache.KeyExists<BsUserDTO>(TheSecondUser, KeyBuilder).Should().BeTrue();
        }

        [Fact(DisplayName = "SetObject_With_TTL_OK")]
        [Trait(TraitName, TraitCacheObjectValue)]
        public void SetObject_With_TTL_OK()
        {
            Redis.Cache.RemoveKey<BsUserDTO>(Users, KeysBuilder);
            Redis.Cache.KeyExists<BsUserDTO>(TheFirstUser, KeyBuilder).Should().BeFalse();
            Redis.Cache.KeyExists<BsUserDTO>(TheSecondUser, KeyBuilder).Should().BeFalse();

            int count = 0;

            Redis.Cache.SetObject<BsUserDTO>(TheFirstUser, KeyBuilder, TimeSpan.FromSeconds(5));
            Redis.Cache.KeyExists<BsUserDTO>(TheFirstUser, KeyBuilder).Should().BeTrue();            
            
            System.Threading.Thread.Sleep(TimeSpan.FromSeconds(5.2));
            Redis.Cache.KeyExists<BsUserDTO>(TheFirstUser, KeyBuilder).Should().BeFalse();
            
            count.Should().Be(0);
            
            Redis.Cache.FetchObject<BsUserDTO>(TheFirstUser, KeyBuilder, () => { count++; return new BsUserDTO(); });
            count.Should().Be(1);
            
            Redis.Cache.KeyExists<BsUserDTO>(TheFirstUser, KeyBuilder).Should().BeTrue();
        }

        [Fact(DisplayName = "GetObject_OK")]
        [Trait(TraitName, TraitCacheObjectValue)]
        public void GetObject_OK()
        {
            Redis.Cache.RemoveKey<BsUserDTO>(Users, KeysBuilder);
            Redis.Cache.KeyExists<BsUserDTO>(TheFirstUser, KeyBuilder).Should().BeFalse();
            Redis.Cache.KeyExists<BsUserDTO>(TheSecondUser, KeyBuilder).Should().BeFalse();

            Redis.Cache.SetObject<BsUserDTO>(TheFirstUser, KeyBuilder);
            Redis.Cache.SetObject<BsUserDTO>(TheSecondUser, KeyBuilder);
            Redis.Cache.KeyExists<BsUserDTO>(TheFirstUser, KeyBuilder).Should().BeTrue();
            Redis.Cache.KeyExists<BsUserDTO>(TheSecondUser, KeyBuilder).Should().BeTrue();

            var theFirstUser = Redis.Cache.GetObject<BsUserDTO>(TheFirstUser, KeyBuilder);
            var theSecondUser = Redis.Cache.GetObject<BsUserDTO>(TheSecondUser, KeyBuilder);

            theFirstUser.Should().NotBeNull();
            theFirstUser.Should().Equals(TheFirstUser);
            theSecondUser.Should().NotBeNull();
            theSecondUser.Should().Equals(TheSecondUser);
        }

        [Fact(DisplayName = "GetObjectByTags_OK")]
        [Trait(TraitName, TraitCacheObjectValue)]
        public void GetObjectByTags_OK()
        {
            Redis.Cache.RemoveTagsFromKey<BsUserDTO>(TheFirstUser, KeyBuilder, TagsBuilder);
            Redis.Cache.RemoveTagsFromKey<BsUserDTO>(TheSecondUser, KeyBuilder, TagsBuilder);

            Redis.Cache.SetObject<BsUserDTO>(TheFirstUser, KeyBuilder, TagsBuilder);
            Redis.Cache.SetObject<BsUserDTO>(TheSecondUser, KeyBuilder, TagsBuilder);

            Redis.Cache.KeyExists<BsUserDTO>(TheFirstUser, KeyBuilder).Should().BeTrue();
            Redis.Cache.KeyExists<BsUserDTO>(TheSecondUser, KeyBuilder).Should().BeTrue();

            var objects = Redis.Cache.GetObjectsByTag<BsUserDTO>(UserTags).ToList();
            objects.Should().NotBeNullOrEmpty();

            var keys = objects.Select(x => x.Id.ToString());
            keys.Should().NotBeNullOrEmpty();
            keys.Should().Contain(UserKeys);
        }

        [Fact(DisplayName = "RemoveKey_Object_OK")]
        [Trait(TraitName, TraitCacheObjectValue)]
        public void RemoveKey_Object_OK()
        {
            Redis.Cache.SetObject<BsUserDTO>(TheFirstUser, KeyBuilder);
            Redis.Cache.SetObject<BsUserDTO>(TheSecondUser, KeyBuilder);

            Redis.Cache.KeyExists<BsUserDTO>(TheFirstUser, KeyBuilder).Should().BeTrue();
            Redis.Cache.KeyExists<BsUserDTO>(TheSecondUser, KeyBuilder).Should().BeTrue();

            Redis.Cache.RemoveKey<BsUserDTO>(Users, KeysBuilder);

            Redis.Cache.KeyExists<BsUserDTO>(TheFirstUser, KeyBuilder).Should().BeFalse();
            Redis.Cache.KeyExists<BsUserDTO>(TheSecondUser, KeyBuilder).Should().BeFalse();
        }

        [Fact(DisplayName = "SetObject_With_Tag_OK")]
        [Trait(TraitName, TraitCacheObjectValue)]
        public void SetObject_With_Tag_OK()
        {
            Redis.Cache.RemoveTagsFromKey<BsUserDTO>(TheFirstUser, KeyBuilder, TagsBuilder);
            Redis.Cache.RemoveTagsFromKey<BsUserDTO>(TheSecondUser, KeyBuilder, TagsBuilder);

            Redis.Cache.SetObject<BsUserDTO>(TheFirstUser, KeyBuilder, TagsBuilder);
            Redis.Cache.SetObject<BsUserDTO>(TheSecondUser, KeyBuilder, TagsBuilder);

            Redis.Cache.KeyExists<BsUserDTO>(TheFirstUser, KeyBuilder).Should().BeTrue();
            Redis.Cache.KeyExists<BsUserDTO>(TheSecondUser, KeyBuilder).Should().BeTrue();           

            var redisKeys = Redis.Cache.GetRawKeysByTag(UserTags, CacheType.Object);
            var keys = new[] { TheFirstUser.Id.ToString(), TheSecondUser.Id.ToString() };
            redisKeys.Should().Contain(keys);            
        }

        [Fact(DisplayName = "AddTagsToKey_Object_OK")]
        [Trait(TraitName, TraitCacheObjectValue)]
        public void AddTagsToKey_Object_OK()
        {
            Redis.Cache.SetObject<BsUserDTO>(TheFirstUser, KeyBuilder);
            Redis.Cache.SetObject<BsUserDTO>(TheSecondUser, KeyBuilder);

            Redis.Cache.KeyExists<BsUserDTO>(TheFirstUser, KeyBuilder).Should().BeTrue();
            Redis.Cache.KeyExists<BsUserDTO>(TheSecondUser, KeyBuilder).Should().BeTrue();

            Redis.Cache.RemoveTagsFromKey<BsUserDTO>(TheFirstUser, KeyBuilder, TagsBuilder);
            Redis.Cache.RemoveTagsFromKey<BsUserDTO>(TheSecondUser, KeyBuilder, TagsBuilder);

            Redis.Cache.GetKeysByTag(UserTags).Should().NotContain(UserKeys);
                        
            Redis.Cache.AddTagsToKey<BsUserDTO>(TheFirstUser, KeyBuilder, TagsBuilder);
            Redis.Cache.AddTagsToKey<BsUserDTO>(TheSecondUser, KeyBuilder, TagsBuilder);

            Redis.Cache.GetRawKeysByTag(UserTags, CacheType.Object).Should().Contain(UserKeys);
        }

        [Fact(DisplayName = "TryGetObject_OK")]
        [Trait(TraitName, TraitCacheObjectValue)]
        public void TryGetObject_OK()
        {
            Redis.Cache.SetObject<BsUserDTO>(TheFirstUser, KeyBuilder);
            Redis.Cache.SetObject<BsUserDTO>(TheSecondUser, KeyBuilder);
            BsUserDTO firstUserDTO;
            BsUserDTO lastUserDTO;
            Redis.Cache.TryGetObject<BsUserDTO>(TheFirstUser, KeyBuilder, out firstUserDTO).Should().BeTrue();
            Redis.Cache.TryGetObject<BsUserDTO>(TheSecondUser, KeyBuilder, out lastUserDTO).Should().BeTrue();
            firstUserDTO.Should().NotBeNull();
            lastUserDTO.Should().NotBeNull();
        }

        [Fact(DisplayName = "RemoveTagsFromObjectKey_OK")]
        [Trait(TraitName, TraitCacheObjectValue)]
        public void RemoveTagsFromObjectKey_OK()
        {
            Redis.Cache.SetObject<BsUserDTO>(TheFirstUser, KeyBuilder, TagsBuilder);
            Redis.Cache.SetObject<BsUserDTO>(TheSecondUser, KeyBuilder, TagsBuilder);

            Redis.Cache.KeyExists<BsUserDTO>(TheFirstUser, KeyBuilder).Should().BeTrue();
            Redis.Cache.KeyExists<BsUserDTO>(TheSecondUser, KeyBuilder).Should().BeTrue();

            Redis.Cache.RemoveTagsFromKey<BsUserDTO>(TheFirstUser, KeyBuilder, TagsBuilder);

            Redis.Cache.RemoveTagsFromKey<BsUserDTO>(TheSecondUser, KeyBuilder, TagsBuilder);
            
            var redisKeys = Redis.Cache.GetKeysByTag(UserTags);

            redisKeys.Should().NotContain(UserKeys);
        }

        [Fact(DisplayName = "FetchObject_NoCacheHit_OK")]
        [Trait(TraitName, TraitCacheObjectValue)]
        public void FetchObject_NoCacheHit_OK()
        {
            Redis.Cache.RemoveKey<BsUserDTO>(Users, KeysBuilder);
            Redis.Cache.KeyExists<BsUserDTO>(TheFirstUser, KeyBuilder).Should().BeFalse();
            Redis.Cache.KeyExists<BsUserDTO>(TheSecondUser, KeyBuilder).Should().BeFalse();
            int theFirstUserId = 10000;
            int theSecondUserId = 20000;
            int count = 0;

            Redis.Cache.FetchObject<BsUserDTO>(TheFirstUser, KeyBuilder, () => { count++; return new BsUserDTO() { Id = theFirstUserId }; });
            count.Should().Be(1);
            
            Redis.Cache.FetchObject<BsUserDTO>(TheFirstUser, KeyBuilder, () => { count++; return new BsUserDTO() { Id = theFirstUserId }; });
            count.Should().Be(1);

            Redis.Cache.FetchObject<BsUserDTO>(TheSecondUser, KeyBuilder, () => { count++; return new BsUserDTO() { Id = theSecondUserId }; });
            count.Should().Be(2);
                        
            Redis.Cache.FetchObject<BsUserDTO>(TheSecondUser, KeyBuilder, () => { count++; return new BsUserDTO() { Id = theSecondUserId }; });
            count.Should().Be(2);

            Redis.Cache.KeyExists<BsUserDTO>(TheFirstUser, KeyBuilder).Should().BeTrue();
            Redis.Cache.KeyExists<BsUserDTO>(TheSecondUser, KeyBuilder).Should().BeTrue();

            var firstCache = Redis.Cache.GetObject<BsUserDTO>(TheFirstUser, KeyBuilder);
            var lastCache = Redis.Cache.GetObject<BsUserDTO>(TheSecondUser, KeyBuilder);

            firstCache.Should().NotBeNull();
            lastCache.Should().NotBeNull();
            firstCache.Id.Should().Equals(theFirstUserId);
            lastCache.Id.Should().Equals(theSecondUserId);
        }

        [Fact(DisplayName = "FetchObject_CacheHit_OK")]
        [Trait(TraitName, TraitCacheObjectValue)]
        public void FetchObject_CacheHit_OK()
        {
            Redis.Cache.SetObject<BsUserDTO>(TheFirstUser, KeyBuilder);
            Redis.Cache.SetObject<BsUserDTO>(TheSecondUser, KeyBuilder);

            int theFirstUserId = 10000;
            int theSecondUserId = 20000;
            int count = 0;
            
            Redis.Cache.FetchObject<BsUserDTO>(TheFirstUser, KeyBuilder, () => { count++; return new BsUserDTO() { Id = theFirstUserId }; });            
            Redis.Cache.FetchObject<BsUserDTO>(TheSecondUser, KeyBuilder, () => { count++; return new BsUserDTO() { Id = theSecondUserId }; });
            
            count.Should().Be(0);

            Redis.Cache.KeyExists<BsUserDTO>(TheFirstUser, KeyBuilder).Should().BeTrue();
            Redis.Cache.KeyExists<BsUserDTO>(TheSecondUser, KeyBuilder).Should().BeTrue();

            var firstCache = Redis.Cache.GetObject<BsUserDTO>(TheFirstUser, KeyBuilder);
            var lastCache = Redis.Cache.GetObject<BsUserDTO>(TheSecondUser, KeyBuilder);

            firstCache.Should().NotBeNull();
            lastCache.Should().NotBeNull();
            firstCache.Id.Should().Equals(TheFirstUser.Id);
            lastCache.Id.Should().Equals(TheSecondUser.Id);
        }

        [Fact(DisplayName = "FetchObjectWithTag_OK")]
        [Trait(TraitName, TraitCacheObjectValue)]
        public void FetchObjectWithTag_OK()
        {
            int theFirstUserId = 10000;
            int theSecondUserId = 20000;
            int count = 0;

            Redis.Cache.RemoveTagsFromKey<BsUserDTO>(TheFirstUser, KeyBuilder, TagsBuilder);
            Redis.Cache.RemoveTagsFromKey<BsUserDTO>(TheSecondUser, KeyBuilder, TagsBuilder);

            Redis.Cache.RemoveKey<BsUserDTO>(Users, KeysBuilder);
            Redis.Cache.KeyExists<BsUserDTO>(TheFirstUser, KeyBuilder).Should().BeFalse();
            Redis.Cache.KeyExists<BsUserDTO>(TheSecondUser, KeyBuilder).Should().BeFalse();
                       
            Redis.Cache.GetRawKeysByTag(UserTags, CacheType.Object).Should().NotContain(UserKeys);

            count.Should().Be(0);

            Redis.Cache.FetchObject<BsUserDTO>(TheFirstUser, KeyBuilder, () => { count++; return new BsUserDTO() { Id = theFirstUserId }; }, TagsBuilder);

            count.Should().Be(1);

            Redis.Cache.FetchObject<BsUserDTO>(TheSecondUser, KeyBuilder, () => { count++; return new BsUserDTO() { Id = theSecondUserId }; }, TagsBuilder);

            count.Should().Be(2);

            Redis.Cache.KeyExists<BsUserDTO>(TheFirstUser, KeyBuilder).Should().BeTrue();
            Redis.Cache.KeyExists<BsUserDTO>(TheSecondUser, KeyBuilder).Should().BeTrue();

            var firstCache = Redis.Cache.GetObject<BsUserDTO>(TheFirstUser, KeyBuilder);
            var lastCache = Redis.Cache.GetObject<BsUserDTO>(TheSecondUser, KeyBuilder);

            firstCache.Should().NotBeNull();
            lastCache.Should().NotBeNull();
            firstCache.Id.Should().Equals(theFirstUserId);
            lastCache.Id.Should().Equals(theSecondUserId);

            Redis.Cache.GetAllTags().Should().Contain(UserTags);
        }

        [Fact(DisplayName = "FetchObjectWithTagBuilder_OK")]
        [Trait(TraitName, TraitCacheObjectValue)]
        public void FetchObjectWithTagBuilder_OK()
        {
            Redis.Cache.FlushAll();

            Redis.Cache.RemoveTagsFromKey<BsUserDTO>(TheFirstUser, KeyBuilder, TagsBuilder);
            Redis.Cache.RemoveTagsFromKey<BsUserDTO>(TheSecondUser, KeyBuilder, TagsBuilder);
            Redis.Cache.RemoveKey<BsUserDTO>(Users, KeysBuilder);
            Redis.Cache.KeyExists<BsUserDTO>(TheFirstUser, KeyBuilder).Should().BeFalse();
            Redis.Cache.KeyExists<BsUserDTO>(TheSecondUser, KeyBuilder).Should().BeFalse();
            
            Redis.Cache.GetRawKeysByTag(UserTags, CacheType.Object).Should().NotContain(UserKeys);
            
            int count = 0;
            Redis.Cache.FetchObject<BsUserDTO>(TheFirstUser, KeyBuilder, () => { count++; return new BsUserDTO() { Id = TheFirstUser.Id }; }, TagsBuilder);
            count.Should().Be(1);

            Redis.Cache.FetchObject<BsUserDTO>(TheSecondUser, KeyBuilder, () => { count++; return new BsUserDTO() { Id = TheSecondUser.Id }; }, TagsBuilder);
            count.Should().Be(2);

            Redis.Cache.KeyExists<BsUserDTO>(TheFirstUser, KeyBuilder).Should().BeTrue();
            Redis.Cache.KeyExists<BsUserDTO>(TheSecondUser, KeyBuilder).Should().BeTrue();

            var theFirstUser = Redis.Cache.GetObject<BsUserDTO>(TheFirstUser, KeyBuilder);
            var theSecondUser = Redis.Cache.GetObject<BsUserDTO>(TheSecondUser, KeyBuilder);

            theFirstUser.Should().NotBeNull();
            theSecondUser.Should().NotBeNull();
            theFirstUser.Id.Should().Equals(TheFirstUser.Id);
            theSecondUser.Id.Should().Equals(TheFirstUser.Id);
            
            Redis.Cache.GetRawKeysByTag(Redis.Cache.GetAllTags().ToArray(), CacheType.Object).Should().Contain(UserKeys);
        }
        #endregion

        #region Hashed cache testing
        [Fact(DisplayName = "SetHashed_OK")]
        [Trait(TraitName, TraitCacheHashedValue)]
        public void SetHashed_OK()
        {
            Redis.Cache.RemoveKey<BsUserDTO>(HashKeyBuilder);
            Redis.Cache.KeyExists<BsUserDTO>(HashKeyBuilder).Should().BeFalse();

            Redis.Cache.SetHashed<BsUserDTO>(Users, HashKeyBuilder, HashFieldsBuilder);
            Redis.Cache.KeyExists<BsUserDTO>(HashKeyBuilder).Should().BeTrue();
        }

        [Fact(DisplayName = "GetHash_OK")]
        [Trait(TraitName, TraitCacheHashedValue)]
        public void GetHash_OK()
        {
            Redis.Cache.RemoveKey<BsUserDTO>(HashKeyBuilder);
            Redis.Cache.KeyExists<BsUserDTO>(HashKeyBuilder).Should().BeFalse();

            Redis.Cache.SetHashed<BsUserDTO>(Users, HashKeyBuilder, HashFieldsBuilder);
            Redis.Cache.KeyExists<BsUserDTO>(HashKeyBuilder).Should().BeTrue();

            var theFirstUser = Redis.Cache.GetHashed<BsUserDTO>(TheFirstUser, HashKeyBuilder, HashFieldBuilder);
            var theLastUser = Redis.Cache.GetHashed<BsUserDTO>(TheSecondUser, HashKeyBuilder, HashFieldBuilder);
            theFirstUser.Should().NotBeNull();
            theFirstUser.Should().Equals(TheFirstUser);
            theLastUser.Should().NotBeNull();
            theLastUser.Should().Equals(TheSecondUser);
        }

        [Fact(DisplayName = "GetHashByTags_OK")]
        [Trait(TraitName, TraitCacheHashedValue)]
        public void GetHashByTags_OK()
        {
            Redis.Cache.RemoveTagsFromHashField<BsUserDTO>(TheFirstUser, HashKeyBuilder, HashFieldBuilder, TagsBuilder);
            Redis.Cache.RemoveTagsFromHashField<BsUserDTO>(TheSecondUser, HashKeyBuilder, HashFieldBuilder, TagsBuilder);

            Redis.Cache.SetHashed<BsUserDTO>(TheFirstUser, HashKeyBuilder, HashFieldBuilder, TagsBuilder);
            Redis.Cache.SetHashed<BsUserDTO>(TheSecondUser, HashKeyBuilder, HashFieldBuilder, TagsBuilder);

            Redis.Cache.KeyExists<BsUserDTO>(HashKeyBuilder).Should().BeTrue();

            var objects = Redis.Cache.GetObjectsByTag<BsUserDTO>(UserTags).ToList();
            objects.Should().NotBeNullOrEmpty();

            var redisKeys = objects.Select(x => x.Id.ToString());
            redisKeys.Should().NotBeNullOrEmpty();
            redisKeys.Should().Contain(UserKeys);
        }

        [Fact(DisplayName = "RemoveHashed_OK")]
        [Trait(TraitName, TraitCacheHashedValue)]
        public void RemoveHashed_OK()
        {
            Redis.Cache.RemoveKey<BsUserDTO>(HashKeyBuilder);
            Redis.Cache.KeyExists<BsUserDTO>(HashKeyBuilder).Should().BeFalse();

            Redis.Cache.SetHashed<BsUserDTO>(Users.ToArray(), HashKeyBuilder, HashFieldsBuilder);
            Redis.Cache.KeyExists<BsUserDTO>(HashKeyBuilder).Should().BeTrue();

            Redis.Cache.RemoveHashed<BsUserDTO>(TheFirstUser, HashKeyBuilder, HashFieldBuilder);
            Redis.Cache.RemoveHashed<BsUserDTO>(TheSecondUser, HashKeyBuilder, HashFieldBuilder);

            var theFirstUser = Redis.Cache.GetHashed<BsUserDTO>(TheFirstUser, HashKeyBuilder, HashFieldBuilder);
            var theLastUser = Redis.Cache.GetHashed<BsUserDTO>(TheSecondUser, HashKeyBuilder, HashFieldBuilder);
            theFirstUser.Should().BeNull();
            theLastUser.Should().BeNull();
        }

        [Fact(DisplayName = "SetHash_With_Tag_OK")]
        [Trait(TraitName, TraitCacheHashedValue)]
        public void SetHash_With_Tag_OK()
        {
            Redis.Cache.RemoveTagsFromHashField<BsUserDTO>(TheFirstUser, HashKeyBuilder, HashFieldBuilder, TagsBuilder);
            Redis.Cache.RemoveTagsFromHashField<BsUserDTO>(TheSecondUser, HashKeyBuilder, HashFieldBuilder, TagsBuilder);

            Redis.Cache.GetRawKeysByTag(UserTags).Should().NotContain(UserKeys);

            Redis.Cache.SetHashed<BsUserDTO>(TheFirstUser, HashKeyBuilder, HashFieldBuilder, TagsBuilder);
            Redis.Cache.SetHashed<BsUserDTO>(TheSecondUser, HashKeyBuilder, HashFieldBuilder, TagsBuilder);

            Redis.Cache.KeyExists<BsUserDTO>(HashKeyBuilder).Should().BeTrue();

            var hashedKeys = Redis.Cache.GetRawKeysByTag(UserTags, CacheType.HashField);
            hashedKeys.Should().NotBeNullOrEmpty();

            hashedKeys.Should().Contain(UserKeys);
        }

        [Fact(DisplayName = "SetHash_With_TTL_OK")]
        [Trait(TraitName, TraitCacheHashedValue)]
        public void SetHash_With_TTL_OK()
        {
            Redis.Cache.RemoveTagsFromHashField<BsUserDTO>(TheFirstUser, HashKeyBuilder, HashFieldBuilder, TagsBuilder);
            Redis.Cache.RemoveTagsFromHashField<BsUserDTO>(TheSecondUser, HashKeyBuilder, HashFieldBuilder, TagsBuilder);

            Redis.Cache.GetRawKeysByTag(UserTags).Should().NotContain(UserKeys);
            int count = 0;

            Redis.Cache.SetHashed<BsUserDTO>(TheFirstUser, HashKeyBuilder, HashFieldBuilder, TagsBuilder, TimeSpan.FromSeconds(5));
            count.Should().Be(0);
            Redis.Cache.FetchHashed<BsUserDTO>(TheFirstUser, HashKeyBuilder, HashFieldBuilder, () => { count++; return new BsUserDTO(); });
            count.Should().Be(0);

            Redis.Cache.KeyExists<BsUserDTO>(HashKeyBuilder).Should().BeTrue();
            System.Threading.Thread.Sleep(TimeSpan.FromSeconds(5.2));
            Redis.Cache.KeyExists<BsUserDTO>(HashKeyBuilder).Should().BeFalse();
            Redis.Cache.FetchHashed<BsUserDTO>(TheFirstUser, HashKeyBuilder, HashFieldBuilder, () => { count++; return new BsUserDTO(); });
            count.Should().Be(1);
            Redis.Cache.KeyExists<BsUserDTO>(HashKeyBuilder).Should().BeTrue();
        }

        [Fact(DisplayName = "AddTagsToKey_Hashed_OK")]
        [Trait(TraitName, TraitCacheHashedValue)]
        public void AddTagsToKey_Hashed_OK()
        {
            Redis.Cache.SetHashed<BsUserDTO>(TheFirstUser, HashKeyBuilder, HashFieldBuilder);
            Redis.Cache.SetHashed<BsUserDTO>(TheSecondUser, HashKeyBuilder, HashFieldBuilder);

            Redis.Cache.KeyExists<BsUserDTO>(HashKeyBuilder).Should().BeTrue();

            Redis.Cache.RemoveTagsFromKey<BsUserDTO>(TheFirstUser, HashKeyBuilder, TagsBuilder);
            Redis.Cache.GetRawKeysByTag(UserTags).Should().NotContain(UserKeys);

            Redis.Cache.AddTagsToKey<BsUserDTO>(TheFirstUser, HashKeyBuilder, TagsBuilder);
            Redis.Cache.GetRawKeysByTag(UserTags).Should().Contain(new string[] { "BsUser:hash" });
        }

        //[Fact(DisplayName = "AddTagsToHashField_OK")]
        //[Trait(TraitName, TraitCacheHashedValue)]
        //public void AddTagsToHashField_OK()
        //{
        //    Redis.Cache.SetHashed<BsUserDTO>(TheFirstUser, HashKeyBuilder, HashFieldBuilder);
        //    Redis.Cache.SetHashed<BsUserDTO>(TheSecondUser, HashKeyBuilder, HashFieldBuilder);

        //    Redis.Cache.KeyExists<BsUserDTO>(HashKeyBuilder).Should().BeTrue();

        //    Redis.Cache.RemoveTagsFromKey<BsUserDTO>(HashKeyBuilder);
        //    Redis.Cache.GetRawKeysByTag(UserTags).Should().NotContain(UserKeys);

        //    Redis.Cache.AddTagsToHashField<BsUserDTO>(TheFirstUser, HashKeyBuilder, HashFieldBuilder, TagsBuilder);
        //    Redis.Cache.AddTagsToHashField<BsUserDTO>(TheSecondUser, HashKeyBuilder, HashFieldBuilder, TagsBuilder);
        //}

        [Fact(DisplayName = "TryGetHashed_OK")]
        [Trait(TraitName, TraitCacheHashedValue)]
        public void TryGetHashed_OK()
        {
            Redis.Cache.SetHashed<BsUserDTO>(TheFirstUser, HashKeyBuilder, HashFieldBuilder);
            Redis.Cache.SetHashed<BsUserDTO>(TheSecondUser, HashKeyBuilder, HashFieldBuilder);
            BsUserDTO theFirstUser;
            BsUserDTO theSecondtUser;
            Redis.Cache.TryGetHashed<BsUserDTO>(TheFirstUser, HashKeyBuilder, HashFieldBuilder, out theFirstUser).Should().BeTrue();
            Redis.Cache.TryGetHashed<BsUserDTO>(TheSecondUser, HashKeyBuilder, HashFieldBuilder, out theSecondtUser).Should().BeTrue();
            theFirstUser.Should().NotBeNull();
            theSecondtUser.Should().NotBeNull();
        }

        [Fact(DisplayName = "RemoveTagsFromHashedKey_OK")]
        [Trait(TraitName, TraitCacheHashedValue)]
        public void RemoveTagsFromHashedKey_OK()
        {
            Redis.Cache.SetHashed<BsUserDTO>(TheFirstUser, HashKeyBuilder, HashFieldBuilder, TagsBuilder);
            Redis.Cache.SetHashed<BsUserDTO>(TheSecondUser, HashKeyBuilder, HashFieldBuilder, TagsBuilder);

            Redis.Cache.KeyExists<BsUserDTO>(HashKeyBuilder).Should().BeTrue();

            Redis.Cache.RemoveTagsFromKey<BsUserDTO>(TheFirstUser, HashKeyBuilder, UserTags);

            var hashedKeys = Redis.Cache.GetKeysByTag(UserTags);

            hashedKeys.Should().NotContain(UserKeys);
        }

        [Fact(DisplayName = "FetchHashed_CacheHit_OK")]
        [Trait(TraitName, TraitCacheHashedValue)]
        public void FetchHashed_CacheHit_OK()
        {
            Redis.Cache.SetHashed<BsUserDTO>(TheFirstUser, HashKeyBuilder, HashFieldBuilder);
            Redis.Cache.SetHashed<BsUserDTO>(TheSecondUser, HashKeyBuilder, HashFieldBuilder);

            int theFirstUserId = 10000;
            int theSecondUserId = 20000;
            int count = 0;

            Redis.Cache.FetchHashed<BsUserDTO>(TheFirstUser, HashKeyBuilder, HashFieldBuilder, () => { count++; return new BsUserDTO() { Id = theFirstUserId }; });

            Redis.Cache.FetchHashed<BsUserDTO>(TheSecondUser, HashKeyBuilder, HashFieldBuilder, () => { count++; return new BsUserDTO() { Id = theSecondUserId }; });

            count.Should().Be(0);

            Redis.Cache.KeyExists<BsUserDTO>(HashKeyBuilder).Should().BeTrue();

            var theFirstUser = Redis.Cache.GetHashed<BsUserDTO>(TheFirstUser, HashKeyBuilder, HashFieldBuilder);
            var theLastUser = Redis.Cache.GetHashed<BsUserDTO>(TheSecondUser, HashKeyBuilder, HashFieldBuilder);

            theFirstUser.Should().NotBeNull();
            theLastUser.Should().NotBeNull();
            theFirstUser.Id.Should().Equals(TheFirstUser.Id);
            theLastUser.Id.Should().Equals(TheSecondUser.Id);
        }

        [Fact(DisplayName = "FetchHashedWithTag_OK")]
        [Trait(TraitName, TraitCacheHashedValue)]
        public void FetchHashedWithTag_OK()
        {
            int theFirstUserId = 10000;
            int theSecondUserId = 20000;
            int count = 0;

            Redis.Cache.RemoveTagsFromKey<BsUserDTO>(TheFirstUser, HashKeyBuilder, TagsBuilder);
            Redis.Cache.RemoveTagsFromKey<BsUserDTO>(TheSecondUser, HashKeyBuilder, TagsBuilder);
            Redis.Cache.RemoveKey<BsUserDTO>(HashKeyBuilder);
            Redis.Cache.KeyExists<BsUserDTO>(HashKeyBuilder).Should().BeFalse();

            Redis.Cache.GetRawKeysByTag(UserTags).Should().NotContain(UserKeys);

            count.Should().Be(0);
            Redis.Cache.FetchHashed<BsUserDTO>(TheFirstUser, HashKeyBuilder, HashFieldBuilder, () => { count++; return new BsUserDTO() { Id = theFirstUserId }; }, TagsBuilder);
            count.Should().Be(1);
            Redis.Cache.FetchHashed<BsUserDTO>(TheSecondUser, HashKeyBuilder, HashFieldBuilder, () => { count++; return new BsUserDTO() { Id = theSecondUserId }; }, TagsBuilder);
            count.Should().Be(2);
            Redis.Cache.KeyExists<BsUserDTO>(HashKeyBuilder).Should().BeTrue();

            var theFirstUser = Redis.Cache.GetHashed<BsUserDTO>(TheFirstUser, HashKeyBuilder, HashFieldBuilder);
            var theSecondUser = Redis.Cache.GetHashed<BsUserDTO>(TheSecondUser, HashKeyBuilder, HashFieldBuilder);

            theFirstUser.Should().NotBeNull();
            theSecondUser.Should().NotBeNull();
            theFirstUser.Id.Should().Equals(theFirstUserId);
            theSecondUser.Id.Should().Equals(theSecondUserId);

            Redis.Cache.GetAllTags().Should().Contain(UserTags);
        }

        [Fact(DisplayName = "FetchHashedWithTagBuilder_OK")]
        [Trait(TraitName, TraitCacheHashedValue)]
        public void FetchHashedWithTagBuilder_OK()
        {
            Redis.Cache.FlushAll();

            int count = 0;

            Redis.Cache.RemoveTagsFromKey<BsUserDTO>(TheFirstUser, KeyBuilder, TagsBuilder);
            Redis.Cache.RemoveTagsFromKey<BsUserDTO>(TheSecondUser, KeyBuilder, TagsBuilder);
            Redis.Cache.RemoveKey<BsUserDTO>(HashKeyBuilder);
            Redis.Cache.KeyExists<BsUserDTO>(HashKeyBuilder).Should().BeFalse();

            Redis.Cache.GetAllTags().Should().NotContain(UserTags);

            count.Should().Be(0);

            Redis.Cache.FetchHashed<BsUserDTO>(TheFirstUser, HashKeyBuilder, HashFieldBuilder, () => { count++; return new BsUserDTO() { Id = TheFirstUser.Id }; }, TagsBuilder);

            count.Should().Be(1);

            Redis.Cache.FetchHashed<BsUserDTO>(TheSecondUser, HashKeyBuilder, HashFieldBuilder, () => { count++; return new BsUserDTO() { Id = TheSecondUser.Id }; }, TagsBuilder);

            count.Should().Be(2);

            Redis.Cache.KeyExists<BsUserDTO>(HashKeyBuilder).Should().BeTrue();

            var theFirstUser = Redis.Cache.GetHashed<BsUserDTO>(TheFirstUser, HashKeyBuilder, HashFieldBuilder);
            var theSecondUser = Redis.Cache.GetHashed<BsUserDTO>(TheSecondUser, HashKeyBuilder, HashFieldBuilder);

            theFirstUser.Should().NotBeNull();
            theSecondUser.Should().NotBeNull();
            theFirstUser.Id.Should().Equals(TheFirstUser.Id);
            theSecondUser.Id.Should().Equals(TheSecondUser.Id);

            Redis.Cache.GetRawKeysByTag(Redis.Cache.GetAllTags().ToArray(), CacheType.HashField).Should().Contain(UserKeys);
        }
        #endregion
    }
}