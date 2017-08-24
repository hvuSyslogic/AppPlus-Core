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
        private const string TraitName = "RedisCacheUnitTests";
        private const string TraitCacheObjectValue = "Object";
        private const string TraitCacheHashedValue = "Hashed";

        Func<BsUserDTO, string> KeyBuilder = (x) => { return "BsUser:" + x.Id; };
        Func<string> HashKeyBuilder = () => { return "BsUser:hash"; };
        Func<BsUserDTO, string[]> tagsBuilder = (x) => { return new string[] { "TheFirstUserTags_1", "TheFirstUserTags_2" }; };
        Func<BsUserDTO, string> fieldBuilder = (x) => { return string.Format("BsUser:ID:{0}", x.Id); };
        
        #region Object cache testing
        [Fact(DisplayName = "SetObject_OK")]
        [Trait(TraitName, TraitCacheObjectValue)]
        public void SetObject_OK()
        {                        
            RedisContext.Cache.RemoveKey<BsUserDTO>(UserKeys);

            RedisContext.Cache.KeyExists<BsUserDTO>(KeyBuilder, TheFirstUser).Should().BeFalse();
            RedisContext.Cache.KeyExists<BsUserDTO>(KeyBuilder, TheSecondUser).Should().BeFalse();
         
            RedisContext.Cache.SetObject<BsUserDTO>(KeyBuilder, TheFirstUser);
            RedisContext.Cache.SetObject<BsUserDTO>(KeyBuilder, TheSecondUser);
         
            RedisContext.Cache.KeyExists<BsUserDTO>(KeyBuilder, TheFirstUser).Should().BeTrue();
            RedisContext.Cache.KeyExists<BsUserDTO>(KeyBuilder, TheSecondUser).Should().BeTrue();
        }

        [Fact(DisplayName = "SetObject_With_TTL_OK")]
        [Trait(TraitName, TraitCacheObjectValue)]
        public void SetObject_With_TTL_OK()
        {            
            RedisContext.Cache.RemoveKey<BsUserDTO>(UserKeys);
            RedisContext.Cache.KeyExists<BsUserDTO>(KeyBuilder, TheFirstUser).Should().BeFalse();

            int count = 0;
         
            RedisContext.Cache.SetObject<BsUserDTO>(KeyBuilder, TheFirstUser, TimeSpan.FromSeconds(5));           
            RedisContext.Cache.KeyExists<BsUserDTO>(KeyBuilder, TheFirstUser).Should().BeTrue();            
            count.Should().Be(0);
            System.Threading.Thread.Sleep(TimeSpan.FromSeconds(5.2));
            RedisContext.Cache.KeyExists<BsUserDTO>(KeyBuilder, TheFirstUser).Should().BeFalse();
            
            RedisContext.Cache.FetchObject<BsUserDTO>(TheFirstUser.Id, () => { count++; return new BsUserDTO(); });            
            count.Should().Be(1);
            RedisContext.Cache.KeyExists<BsUserDTO>(KeyBuilder, TheFirstUser).Should().BeTrue();
        }

        [Fact(DisplayName = "GetObject_OK")]
        [Trait(TraitName, TraitCacheObjectValue)]
        public void GetObject_OK()
        {           
            RedisContext.Cache.RemoveKey<BsUserDTO>(UserKeys);
            RedisContext.Cache.KeyExists<BsUserDTO>(KeyBuilder, TheFirstUser).Should().BeFalse();
            RedisContext.Cache.KeyExists<BsUserDTO>(KeyBuilder, TheSecondUser).Should().BeFalse();

            RedisContext.Cache.SetObject<BsUserDTO>(KeyBuilder, TheFirstUser);
            RedisContext.Cache.SetObject<BsUserDTO>(KeyBuilder, TheSecondUser);
            RedisContext.Cache.KeyExists<BsUserDTO>(KeyBuilder, TheFirstUser).Should().BeTrue();
            RedisContext.Cache.KeyExists<BsUserDTO>(KeyBuilder, TheSecondUser).Should().BeTrue();

            var theFirstUser = RedisContext.Cache.GetObject<BsUserDTO>(KeyBuilder, TheFirstUser);
            var theSecondUser = RedisContext.Cache.GetObject<BsUserDTO>(KeyBuilder, TheSecondUser);

            theFirstUser.Should().NotBeNull();
            theFirstUser.Should().Equals(TheFirstUser);
            theSecondUser.Should().NotBeNull();
            theSecondUser.Should().Equals(TheSecondUser);
        }

        [Fact(DisplayName = "GetObjectByTags_OK")]
        [Trait(TraitName, TraitCacheObjectValue)]
        public void GetObjectByTags_OK()
        {
            RedisContext.Cache.RemoveTagsFromKey<BsUserDTO>(TheFirstUserTags, CacheType.Object, TheFirstUser.Id);
            RedisContext.Cache.RemoveTagsFromKey<BsUserDTO>(TheSecondUserTags, CacheType.Object, TheSecondUser.Id);

            RedisContext.Cache.SetObject<BsUserDTO>(KeyBuilder, TheFirstUser, tagsBuilder);
            RedisContext.Cache.SetObject<BsUserDTO>(KeyBuilder, TheSecondUser, tagsBuilder);

            RedisContext.Cache.KeyExists<BsUserDTO>(KeyBuilder, TheFirstUser).Should().BeTrue();
            RedisContext.Cache.KeyExists<BsUserDTO>(KeyBuilder, TheSecondUser).Should().BeTrue();

            var objects = RedisContext.Cache.GetObjectsByTag<BsUserDTO>(UserTags).ToList();
            objects.Should().NotBeNullOrEmpty();

            var redisKeys = objects.Select(x => x.Id.ToString());
            redisKeys.Should().NotBeNullOrEmpty();
            redisKeys.Should().Contain(UserKeys);
        }

        [Fact(DisplayName = "RemoveKey_Object_OK")]
        [Trait(TraitName, TraitCacheObjectValue)]
        public void RemoveKey_Object_OK()
        {
            RedisContext.Cache.SetObject<BsUserDTO>(KeyBuilder, TheFirstUser);
            RedisContext.Cache.SetObject<BsUserDTO>(KeyBuilder, TheSecondUser);

            RedisContext.Cache.KeyExists<BsUserDTO>(KeyBuilder, TheFirstUser).Should().BeTrue();
            RedisContext.Cache.KeyExists<BsUserDTO>(KeyBuilder, TheSecondUser).Should().BeTrue();

            RedisContext.Cache.RemoveKey<BsUserDTO>(new object[] { TheFirstUser.Id, TheSecondUser.Id });

            RedisContext.Cache.KeyExists<BsUserDTO>(KeyBuilder, TheFirstUser).Should().BeFalse();
            RedisContext.Cache.KeyExists<BsUserDTO>(KeyBuilder, TheSecondUser).Should().BeFalse();
        }

        [Fact(DisplayName = "SetObject_With_Tag_OK")]
        [Trait(TraitName, TraitCacheObjectValue)]
        public void SetObject_With_Tag_OK()
        {
            RedisContext.Cache.RemoveTagsFromKey<BsUserDTO>(TheFirstUserTags, CacheType.Object, TheFirstUser.Id);
            RedisContext.Cache.RemoveTagsFromKey<BsUserDTO>(TheSecondUserTags, CacheType.Object, TheSecondUser.Id);

            RedisContext.Cache.SetObject<BsUserDTO>(KeyBuilder, TheFirstUser, tagsBuilder);
            RedisContext.Cache.SetObject<BsUserDTO>(KeyBuilder, TheSecondUser, tagsBuilder);

            RedisContext.Cache.KeyExists<BsUserDTO>(KeyBuilder, TheFirstUser).Should().BeTrue();
            RedisContext.Cache.KeyExists<BsUserDTO>(KeyBuilder, TheSecondUser).Should().BeTrue();           

            var redisKeys = RedisContext.Cache.GetRawKeysByTag(UserTags, CacheType.Object);
            var keys = new[] { TheFirstUser.Id.ToString(), TheSecondUser.Id.ToString() };
            redisKeys.Should().Contain(keys);            
        }

        [Fact(DisplayName = "AddTagsToKey_Object_OK")]
        [Trait(TraitName, TraitCacheObjectValue)]
        public void AddTagsToKey_Object_OK()
        {
            RedisContext.Cache.SetObject<BsUserDTO>(KeyBuilder, TheFirstUser);
            RedisContext.Cache.SetObject<BsUserDTO>(KeyBuilder, TheSecondUser);

            RedisContext.Cache.KeyExists<BsUserDTO>(KeyBuilder, TheFirstUser).Should().BeTrue();
            RedisContext.Cache.KeyExists<BsUserDTO>(KeyBuilder, TheSecondUser).Should().BeTrue();

            // Remove tag for the key
            RedisContext.Cache.RemoveTagsFromKey<BsUserDTO>(TheFirstUserTags, CacheType.Object, TheFirstUser.Id);
            RedisContext.Cache.RemoveTagsFromKey<BsUserDTO>(TheSecondUserTags, CacheType.Object, TheSecondUser.Id);

            RedisContext.Cache.GetKeysByTag(UserTags).Should().NotContain(UserKeys);
            
            // Add tags to the key
            RedisContext.Cache.AddTagsToKey<BsUserDTO>(TheFirstUserTags, CacheType.Object, TheFirstUser.Id);
            RedisContext.Cache.AddTagsToKey<BsUserDTO>(TheSecondUserTags, CacheType.Object, TheSecondUser.Id);

            RedisContext.Cache.GetRawKeysByTag(UserTags, CacheType.Object).Should().Contain(UserKeys);
        }

        [Fact(DisplayName = "TryGetObject_OK")]
        [Trait(TraitName, TraitCacheObjectValue)]
        public void TryGetObject_OK()
        {
            RedisContext.Cache.SetObject<BsUserDTO>(KeyBuilder, TheFirstUser);
            RedisContext.Cache.SetObject<BsUserDTO>(KeyBuilder, TheSecondUser);
            BsUserDTO firstUserDTO;
            BsUserDTO lastUserDTO;
            RedisContext.Cache.TryGetObject<BsUserDTO>(TheFirstUser.Id, out firstUserDTO).Should().BeTrue();
            RedisContext.Cache.TryGetObject<BsUserDTO>(TheSecondUser.Id, out lastUserDTO).Should().BeTrue();
            firstUserDTO.Should().NotBeNull();
            lastUserDTO.Should().NotBeNull();
        }

        [Fact(DisplayName = "RemoveTagsFromObjectKey_OK")]
        [Trait(TraitName, TraitCacheObjectValue)]
        public void RemoveTagsFromObjectKey_OK()
        {
            RedisContext.Cache.SetObject<BsUserDTO>(KeyBuilder, TheFirstUser, tagsBuilder);
            RedisContext.Cache.SetObject<BsUserDTO>(KeyBuilder, TheSecondUser, tagsBuilder);

            RedisContext.Cache.KeyExists<BsUserDTO>(KeyBuilder, TheFirstUser).Should().BeTrue();
            RedisContext.Cache.KeyExists<BsUserDTO>(KeyBuilder, TheSecondUser).Should().BeTrue();

            RedisContext.Cache.RemoveTagsFromKey<BsUserDTO>(TheFirstUserTags, CacheType.Object, TheFirstUser.Id);

            RedisContext.Cache.RemoveTagsFromKey<BsUserDTO>(TheSecondUserTags, CacheType.Object, TheSecondUser.Id);
            
            var redisKeys = RedisContext.Cache.GetKeysByTag(UserTags);

            redisKeys.Should().NotContain(UserKeys);
        }

        [Fact(DisplayName = "FetchObject_NoCacheHit_OK")]
        [Trait(TraitName, TraitCacheObjectValue)]
        public void FetchObject_NoCacheHit_OK()
        {
            RedisContext.Cache.RemoveKey<BsUserDTO>(UserKeys);
            RedisContext.Cache.KeyExists<BsUserDTO>(KeyBuilder, TheFirstUser).Should().BeFalse();
            RedisContext.Cache.KeyExists<BsUserDTO>(KeyBuilder, TheSecondUser).Should().BeFalse();
            int theFirstUserId = 10000;
            int theSecondUserId = 20000;
            int count = 0;

            // None cahe hit
            RedisContext.Cache.FetchObject<BsUserDTO>(TheFirstUser.Id, () => { count++; return new BsUserDTO() { Id = theFirstUserId }; });
            count.Should().Be(1);

            // Cache hit
            RedisContext.Cache.FetchObject<BsUserDTO>(TheFirstUser.Id, () => { count++; return new BsUserDTO() { Id = theFirstUserId }; });
            count.Should().Be(1);

            // None cahe hit
            RedisContext.Cache.FetchObject<BsUserDTO>(TheSecondUser.Id, () => { count++; return new BsUserDTO() { Id = theSecondUserId }; });
            count.Should().Be(2);
            
            // Cache hit
            RedisContext.Cache.FetchObject<BsUserDTO>(TheSecondUser.Id, () => { count++; return new BsUserDTO() { Id = theSecondUserId }; });
            count.Should().Be(2);

            RedisContext.Cache.KeyExists<BsUserDTO>(KeyBuilder, TheFirstUser).Should().BeTrue();
            RedisContext.Cache.KeyExists<BsUserDTO>(KeyBuilder, TheSecondUser).Should().BeTrue();

            var firstCache = RedisContext.Cache.GetObject<BsUserDTO>(KeyBuilder, TheFirstUser);
            var lastCache = RedisContext.Cache.GetObject<BsUserDTO>(KeyBuilder, TheSecondUser);

            firstCache.Should().NotBeNull();
            lastCache.Should().NotBeNull();
            firstCache.Id.Should().Equals(theFirstUserId);
            lastCache.Id.Should().Equals(theSecondUserId);
        }

        [Fact(DisplayName = "FetchObject_CacheHit_OK")]
        [Trait(TraitName, TraitCacheObjectValue)]
        public void FetchObject_CacheHit_OK()
        {
            RedisContext.Cache.SetObject<BsUserDTO>(KeyBuilder, TheFirstUser);
            RedisContext.Cache.SetObject<BsUserDTO>(KeyBuilder, TheSecondUser);

            int theFirstUserId = 10000;
            int theSecondUserId = 20000;
            int count = 0;

            // Cache hit
            RedisContext.Cache.FetchObject<BsUserDTO>(TheFirstUser.Id, () => { count++; return new BsUserDTO() { Id = theFirstUserId }; });
            // Cache hit
            RedisContext.Cache.FetchObject<BsUserDTO>(TheSecondUser.Id, () => { count++; return new BsUserDTO() { Id = theSecondUserId }; });
            
            count.Should().Be(0);

            RedisContext.Cache.KeyExists<BsUserDTO>(KeyBuilder, TheFirstUser).Should().BeTrue();
            RedisContext.Cache.KeyExists<BsUserDTO>(KeyBuilder, TheSecondUser).Should().BeTrue();

            var firstCache = RedisContext.Cache.GetObject<BsUserDTO>(KeyBuilder, TheFirstUser);
            var lastCache = RedisContext.Cache.GetObject<BsUserDTO>(KeyBuilder, TheSecondUser);

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

            RedisContext.Cache.RemoveTagsFromKey<BsUserDTO>(TheFirstUserTags, CacheType.Object, TheFirstUser.Id);
            RedisContext.Cache.RemoveTagsFromKey<BsUserDTO>(TheSecondUserTags, CacheType.Object, TheSecondUser.Id);

            RedisContext.Cache.RemoveKey<BsUserDTO>(UserKeys);
            RedisContext.Cache.KeyExists<BsUserDTO>(KeyBuilder, TheFirstUser).Should().BeFalse();
            RedisContext.Cache.KeyExists<BsUserDTO>(KeyBuilder, TheSecondUser).Should().BeFalse();
                       
            RedisContext.Cache.GetRawKeysByTag(UserTags, CacheType.Object).Should().NotContain(UserKeys);

            count.Should().Be(0);

            RedisContext.Cache.FetchObject<BsUserDTO>(TheFirstUser.Id,
                () => { count++; return new BsUserDTO() { Id = theFirstUserId }; }, TheFirstUserTags);

            count.Should().Be(1);

            RedisContext.Cache.FetchObject<BsUserDTO>(TheSecondUser.Id,
                () => { count++; return new BsUserDTO() { Id = theSecondUserId }; }, TheSecondUserTags);

            count.Should().Be(2);

            RedisContext.Cache.KeyExists<BsUserDTO>(KeyBuilder, TheFirstUser).Should().BeTrue();
            RedisContext.Cache.KeyExists<BsUserDTO>(KeyBuilder, TheSecondUser).Should().BeTrue();

            var firstCache = RedisContext.Cache.GetObject<BsUserDTO>(KeyBuilder, TheFirstUser);
            var lastCache = RedisContext.Cache.GetObject<BsUserDTO>(KeyBuilder, TheSecondUser);

            firstCache.Should().NotBeNull();
            lastCache.Should().NotBeNull();
            firstCache.Id.Should().Equals(theFirstUserId);
            lastCache.Id.Should().Equals(theSecondUserId);

            RedisContext.Cache.GetAllTags().Should().Contain(UserTags);
        }

        [Fact(DisplayName = "FetchObjectWithTagBuilder_OK")]
        [Trait(TraitName, TraitCacheObjectValue)]
        public void FetchObjectWithTagBuilder_OK()
        {
            RedisContext.Cache.FlushAll();

            RedisContext.Cache.RemoveTagsFromKey<BsUserDTO>(TheFirstUserTags, CacheType.Object, TheFirstUser.Id);
            RedisContext.Cache.RemoveTagsFromKey<BsUserDTO>(TheSecondUserTags, CacheType.Object, TheSecondUser.Id);
            RedisContext.Cache.RemoveKey<BsUserDTO>(UserKeys);
            RedisContext.Cache.KeyExists<BsUserDTO>(KeyBuilder, TheFirstUser).Should().BeFalse();
            RedisContext.Cache.KeyExists<BsUserDTO>(KeyBuilder, TheSecondUser).Should().BeFalse();
            
            RedisContext.Cache.GetRawKeysByTag(UserTags, CacheType.Object).Should().NotContain(UserKeys);
            
            int count = 0;
            RedisContext.Cache.FetchObject<BsUserDTO>(TheFirstUser.Id,
                () => { count++; return new BsUserDTO() { Id = TheFirstUser.Id }; }, 
                x => new[] { string.Format("TAG_{0}_1", x.Id), string.Format("TAG_{0}_2", x.Id) });
            count.Should().Be(1);

            RedisContext.Cache.FetchObject<BsUserDTO>(TheSecondUser.Id,
                () => { count++; return new BsUserDTO() { Id = TheSecondUser.Id }; }, 
                x => new[] { string.Format("TAG_{0}_1", x.Id), string.Format("TAG_{0}_2", x.Id) });
            count.Should().Be(2);

            RedisContext.Cache.KeyExists<BsUserDTO>(KeyBuilder, TheFirstUser).Should().BeTrue();
            RedisContext.Cache.KeyExists<BsUserDTO>(KeyBuilder, TheSecondUser).Should().BeTrue();

            var theFirstUser = RedisContext.Cache.GetObject<BsUserDTO>(KeyBuilder, TheFirstUser);
            var theSecondUser = RedisContext.Cache.GetObject<BsUserDTO>(KeyBuilder, TheSecondUser);

            theFirstUser.Should().NotBeNull();
            theSecondUser.Should().NotBeNull();
            theFirstUser.Id.Should().Equals(TheFirstUser.Id);
            theSecondUser.Id.Should().Equals(TheFirstUser.Id);
            
            RedisContext.Cache.GetRawKeysByTag(RedisContext.Cache.GetAllTags().ToArray(), CacheType.Object).Should().Contain(UserKeys);
        }
        #endregion

        #region Hashed cache testing
        [Fact(DisplayName = "SetHashed_OK")]
        [Trait(TraitName, TraitCacheHashedValue)]
        public void SetHashed_OK()
        {
            RedisContext.Cache.RemoveKey<BsUserDTO>();
            RedisContext.Cache.KeyExists<BsUserDTO>(HashKeyBuilder).Should().BeFalse();
            IDictionary<object, BsUserDTO> fieldValues = new Dictionary<object, BsUserDTO>();
            AllUsers.ToList().ForEach(x =>
            {
                fieldValues.Add(x.Id, x);
            });
            RedisContext.Cache.SetHashed<BsUserDTO>(fieldValues);
            RedisContext.Cache.KeyExists<BsUserDTO>(HashKeyBuilder).Should().BeTrue();
        }

        [Fact(DisplayName = "GetHash_OK")]
        [Trait(TraitName, TraitCacheHashedValue)]
        public void GetHash_OK()
        {
            RedisContext.Cache.RemoveKey<BsUserDTO>();
            RedisContext.Cache.KeyExists<BsUserDTO>(HashKeyBuilder).Should().BeFalse();
            IDictionary<object, BsUserDTO> fieldValues = new Dictionary<object, BsUserDTO>();
            AllUsers.ToList().ForEach(x =>
            {
                fieldValues.Add(x.Id, x);
            });
            RedisContext.Cache.SetHashed<BsUserDTO>(fieldValues);
            RedisContext.Cache.KeyExists<BsUserDTO>(HashKeyBuilder).Should().BeTrue();

            var theFirstUser = RedisContext.Cache.GetHashed<BsUserDTO>(TheFirstUser.Id);
            var theLastUser = RedisContext.Cache.GetHashed<BsUserDTO>(TheSecondUser.Id);
            theFirstUser.Should().NotBeNull();
            theFirstUser.Should().Equals(TheFirstUser);
            theLastUser.Should().NotBeNull();
            theLastUser.Should().Equals(TheSecondUser);
        }

        [Fact(DisplayName = "GetHashByTags_OK")]
        [Trait(TraitName, TraitCacheHashedValue)]
        public void GetHashByTags_OK()
        {
            RedisContext.Cache.RemoveTagsFromHashField<BsUserDTO>(TheFirstUser.Id, TheFirstUserTags);
            RedisContext.Cache.RemoveTagsFromHashField<BsUserDTO>(TheSecondUser.Id, TheSecondUserTags);

            RedisContext.Cache.SetHashed<BsUserDTO>(TheFirstUser.Id, TheFirstUser, TheFirstUserTags);
            RedisContext.Cache.SetHashed<BsUserDTO>(TheSecondUser.Id, TheSecondUser, TheSecondUserTags);

            RedisContext.Cache.KeyExists<BsUserDTO>(HashKeyBuilder).Should().BeTrue();

            var objects = RedisContext.Cache.GetObjectsByTag<BsUserDTO>(UserTags).ToList();
            objects.Should().NotBeNullOrEmpty();

            var redisKeys = objects.Select(x => x.Id.ToString());
            redisKeys.Should().NotBeNullOrEmpty();
            redisKeys.Should().Contain(UserKeys);
        }

        [Fact(DisplayName = "RemoveHashed_OK")]
        [Trait(TraitName, TraitCacheHashedValue)]
        public void RemoveHashed_OK()
        {
            RedisContext.Cache.RemoveKey<BsUserDTO>();
            RedisContext.Cache.KeyExists<BsUserDTO>(HashKeyBuilder).Should().BeFalse();
            IDictionary<object, BsUserDTO> fieldValues = new Dictionary<object, BsUserDTO>();
            AllUsers.ToList().ForEach(x =>
            {
                fieldValues.Add(x.Id, x);
            });
            RedisContext.Cache.SetHashed<BsUserDTO>(fieldValues);
            RedisContext.Cache.KeyExists<BsUserDTO>(HashKeyBuilder).Should().BeTrue();

            RedisContext.Cache.RemoveHashed<BsUserDTO>(TheFirstUser.Id);
            RedisContext.Cache.RemoveHashed<BsUserDTO>(TheSecondUser.Id);

            var theFirstUser = RedisContext.Cache.GetHashed<BsUserDTO>(TheFirstUser.Id);
            var theLastUser = RedisContext.Cache.GetHashed<BsUserDTO>(TheSecondUser.Id);
            theFirstUser.Should().BeNull();
            theLastUser.Should().BeNull();
        }

        [Fact(DisplayName = "SetHash_With_Tag_OK")]
        [Trait(TraitName, TraitCacheHashedValue)]
        public void SetHash_With_Tag_OK()
        {
            RedisContext.Cache.RemoveTagsFromHashField<BsUserDTO>(TheFirstUser.Id, TheFirstUserTags);
            RedisContext.Cache.RemoveTagsFromHashField<BsUserDTO>(TheSecondUser.Id, TheSecondUserTags);

            RedisContext.Cache.GetRawKeysByTag(UserTags).Should().NotContain(UserKeys);

            RedisContext.Cache.SetHashed<BsUserDTO>(TheFirstUser.Id, TheFirstUser, TheFirstUserTags);
            RedisContext.Cache.SetHashed<BsUserDTO>(TheSecondUser.Id, TheSecondUser, TheSecondUserTags);

            RedisContext.Cache.KeyExists<BsUserDTO>(HashKeyBuilder).Should().BeTrue();
            
            var hashedKeys = RedisContext.Cache.GetRawKeysByTag(UserTags, CacheType.HashField);
            hashedKeys.Should().NotBeNullOrEmpty();

            hashedKeys.Should().Contain(UserKeys);
        }

        [Fact(DisplayName = "SetHash_With_TTL_OK")]
        [Trait(TraitName, TraitCacheHashedValue)]
        public void SetHash_With_TTL_OK()
        {
            RedisContext.Cache.RemoveTagsFromHashField<BsUserDTO>(TheFirstUser.Id, TheFirstUserTags);
            RedisContext.Cache.RemoveTagsFromHashField<BsUserDTO>(TheSecondUser.Id, TheSecondUserTags);

            RedisContext.Cache.GetRawKeysByTag(UserTags).Should().NotContain(UserKeys);
            int count = 0;
            
            RedisContext.Cache.SetHashed<BsUserDTO>(TheFirstUser.Id, TheFirstUser, TheFirstUserTags, TimeSpan.FromSeconds(5));
            count.Should().Be(0);
            RedisContext.Cache.FetchHashed<BsUserDTO>(TheFirstUser, HashKeyBuilder, fieldBuilder, () => { count++; return new BsUserDTO(); });
            count.Should().Be(0);

            RedisContext.Cache.KeyExists<BsUserDTO>(HashKeyBuilder).Should().BeTrue();
            System.Threading.Thread.Sleep(TimeSpan.FromSeconds(5.2));
            RedisContext.Cache.KeyExists<BsUserDTO>(HashKeyBuilder).Should().BeFalse();
            RedisContext.Cache.FetchHashed<BsUserDTO>(TheFirstUser, HashKeyBuilder, fieldBuilder, () => { count++; return new BsUserDTO(); });
            count.Should().Be(1);
            RedisContext.Cache.KeyExists<BsUserDTO>(HashKeyBuilder).Should().BeTrue();
        }

        [Fact(DisplayName = "AddTagsToKey_Hashed_OK")]
        [Trait(TraitName, TraitCacheHashedValue)]
        public void AddTagsToKey_Hashed_OK()
        {
            RedisContext.Cache.SetHashed<BsUserDTO>(TheFirstUser.Id, TheFirstUser);
            RedisContext.Cache.SetHashed<BsUserDTO>(TheSecondUser.Id, TheSecondUser);

            RedisContext.Cache.KeyExists<BsUserDTO>(HashKeyBuilder).Should().BeTrue();

            // Remove tag for the key
            RedisContext.Cache.RemoveTagsFromKey<BsUserDTO>(UserTags);
            RedisContext.Cache.GetRawKeysByTag(UserTags).Should().NotContain(UserKeys);

            //var redisKeys = RedisContext.Cache.GetKeysByTag(Tags).ToList();
            //var rawKeys = RedisContext.Cache.GetRawKeysByTag(Tags).ToList();

            // Add tags to the key
            RedisContext.Cache.AddTagsToKey<BsUserDTO>(UserTags);
            RedisContext.Cache.GetRawKeysByTag(UserTags).Should().Contain(new string[] { "BsUser:hash" });
        }

        [Fact(DisplayName = "AddTagsToHashField_OK")]
        [Trait(TraitName, TraitCacheHashedValue)]
        public void AddTagsToHashField_OK()
        {
            RedisContext.Cache.SetHashed<BsUserDTO>(TheFirstUser.Id, TheFirstUser);
            RedisContext.Cache.SetHashed<BsUserDTO>(TheSecondUser.Id, TheSecondUser);

            RedisContext.Cache.KeyExists<BsUserDTO>(HashKeyBuilder).Should().BeTrue();

            // Remove tag for the key
            RedisContext.Cache.RemoveTagsFromKey<BsUserDTO>(UserTags);
            RedisContext.Cache.GetRawKeysByTag(UserTags).Should().NotContain(UserKeys);

            //var redisKeys = RedisContext.Cache.GetKeysByTag(tags).ToList();
            //var rawKeys = RedisContext.Cache.GetRawKeysByTag(tags).ToList();

            // Add tags to the hashed field
            RedisContext.Cache.AddTagsToHashField<BsUserDTO>(TheFirstUser.Id, TheFirstUserTags);
            RedisContext.Cache.AddTagsToHashField<BsUserDTO>(TheSecondUser.Id, TheSecondUserTags);
        }

        [Fact(DisplayName = "TryGetHashed_OK")]
        [Trait(TraitName, TraitCacheHashedValue)]
        public void TryGetHashed_OK()
        {
            RedisContext.Cache.SetHashed<BsUserDTO>(TheFirstUser.Id, TheFirstUser);
            RedisContext.Cache.SetHashed<BsUserDTO>(TheSecondUser.Id, TheSecondUser);
            BsUserDTO firstUserDTO;
            BsUserDTO lastUserDTO;
            RedisContext.Cache.TryGetHashed<BsUserDTO>(TheFirstUser.Id, out firstUserDTO).Should().BeTrue();
            RedisContext.Cache.TryGetHashed<BsUserDTO>(TheSecondUser.Id, out lastUserDTO).Should().BeTrue();
            firstUserDTO.Should().NotBeNull();
            lastUserDTO.Should().NotBeNull();
        }

        [Fact(DisplayName = "RemoveTagsFromHashedKey_OK")]
        [Trait(TraitName, TraitCacheHashedValue)]
        public void RemoveTagsFromHashedKey_OK()
        {
            RedisContext.Cache.SetHashed<BsUserDTO>(TheFirstUser.Id, TheFirstUser, TheFirstUserTags);
            RedisContext.Cache.SetHashed<BsUserDTO>(TheSecondUser.Id, TheSecondUser, TheSecondUserTags);

            RedisContext.Cache.KeyExists<BsUserDTO>(HashKeyBuilder).Should().BeTrue();

            RedisContext.Cache.RemoveTagsFromKey<BsUserDTO>(UserTags);

            var hashedKeys = RedisContext.Cache.GetKeysByTag(UserTags);

            hashedKeys.Should().NotContain(UserKeys);
        }

        [Fact(DisplayName = "FetchHashed_CacheHit_OK")]
        [Trait(TraitName, TraitCacheHashedValue)]
        public void FetchHashed_CacheHit_OK()
        {
            RedisContext.Cache.SetHashed<BsUserDTO>(TheFirstUser.Id, TheFirstUser);
            RedisContext.Cache.SetHashed<BsUserDTO>(TheSecondUser.Id, TheSecondUser);

            int theFirstUserId = 10000;
            int theSecondUserId = 20000;
            int count = 0;
            
            RedisContext.Cache.FetchHashed<BsUserDTO>(TheFirstUser, HashKeyBuilder, fieldBuilder, () => { count++; return new BsUserDTO() { Id = theFirstUserId }; });

            RedisContext.Cache.FetchHashed<BsUserDTO>(TheSecondUser, HashKeyBuilder, fieldBuilder, () => { count++; return new BsUserDTO() { Id = theSecondUserId }; });

            count.Should().Be(0);

            RedisContext.Cache.KeyExists<BsUserDTO>(HashKeyBuilder).Should().BeTrue();            

            var theFirstUser = RedisContext.Cache.GetHashed<BsUserDTO>(TheFirstUser.Id);
            var theLastUser = RedisContext.Cache.GetHashed<BsUserDTO>(TheSecondUser.Id);

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

            RedisContext.Cache.RemoveTagsFromKey<BsUserDTO>(TheFirstUserTags);
            RedisContext.Cache.RemoveTagsFromKey<BsUserDTO>(TheSecondUserTags);
            RedisContext.Cache.RemoveKey<BsUserDTO>();
            RedisContext.Cache.KeyExists<BsUserDTO>(HashKeyBuilder).Should().BeFalse();

            RedisContext.Cache.GetRawKeysByTag(UserTags).Should().NotContain(UserKeys);

            count.Should().Be(0);
            RedisContext.Cache.FetchHashed<BsUserDTO>(TheFirstUser, HashKeyBuilder, fieldBuilder, () => { count++; return new BsUserDTO() { Id = theFirstUserId }; }, tagsBuilder);
            count.Should().Be(1);
            RedisContext.Cache.FetchHashed<BsUserDTO>(TheSecondUser, HashKeyBuilder, fieldBuilder, () => { count++; return new BsUserDTO() { Id = theSecondUserId }; }, tagsBuilder);
            count.Should().Be(2);
            RedisContext.Cache.KeyExists<BsUserDTO>(HashKeyBuilder).Should().BeTrue();

            var theFirstUser = RedisContext.Cache.GetHashed<BsUserDTO>(TheFirstUser.Id);
            var theSecondUser = RedisContext.Cache.GetHashed<BsUserDTO>(TheSecondUser.Id);

            theFirstUser.Should().NotBeNull();
            theSecondUser.Should().NotBeNull();
            theFirstUser.Id.Should().Equals(theFirstUserId);
            theSecondUser.Id.Should().Equals(theSecondUserId);

            RedisContext.Cache.GetAllTags().Should().Contain(UserTags);
        }

        [Fact(DisplayName = "FetchHashedWithTagBuilder_OK")]
        [Trait(TraitName, TraitCacheHashedValue)]
        public void FetchHashedWithTagBuilder_OK()
        {
            RedisContext.Cache.FlushAll();

            int count = 0;

            RedisContext.Cache.RemoveTagsFromKey<BsUserDTO>(TheFirstUserTags);
            RedisContext.Cache.RemoveTagsFromKey<BsUserDTO>(TheSecondUserTags);
            RedisContext.Cache.RemoveKey<BsUserDTO>();
            RedisContext.Cache.KeyExists<BsUserDTO>(HashKeyBuilder).Should().BeFalse();

            RedisContext.Cache.GetAllTags().Should().NotContain(UserTags);
            
            count.Should().Be(0);

            RedisContext.Cache.FetchHashed<BsUserDTO>(TheFirstUser, HashKeyBuilder, fieldBuilder, 
                () => { count++; return new BsUserDTO() { Id = TheFirstUser.Id }; }, 
                x => new[] { string.Format("TAG_{0}_1", x.Id), string.Format("TAG_{0}_2", x.Id) });
            
            count.Should().Be(1);

            RedisContext.Cache.FetchHashed<BsUserDTO>(TheSecondUser, HashKeyBuilder, fieldBuilder,
                () => { count++; return new BsUserDTO() { Id = TheSecondUser.Id }; },
                x => new[] { string.Format("TAG_{0}_1", x.Id), string.Format("TAG_{0}_2", x.Id) });

            count.Should().Be(2);

            RedisContext.Cache.KeyExists<BsUserDTO>(HashKeyBuilder).Should().BeTrue();

            var theFirstUser = RedisContext.Cache.GetHashed<BsUserDTO>(TheFirstUser.Id);
            var theSecondUser = RedisContext.Cache.GetHashed<BsUserDTO>(TheSecondUser.Id);

            theFirstUser.Should().NotBeNull();
            theSecondUser.Should().NotBeNull();
            theFirstUser.Id.Should().Equals(TheFirstUser.Id);
            theSecondUser.Id.Should().Equals(TheSecondUser.Id);
            
            RedisContext.Cache.GetRawKeysByTag(RedisContext.Cache.GetAllTags().ToArray(), CacheType.HashField).Should().Contain(UserKeys); 
        }
        #endregion
    }
}