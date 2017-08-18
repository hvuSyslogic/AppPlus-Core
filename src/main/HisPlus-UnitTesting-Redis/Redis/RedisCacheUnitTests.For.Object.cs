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
        
        private string[] tags_1 = new string[] { "The_Tag_1_For_The_First_User", "The_Tag_2_For_The_First_User" };
        private string[] tags_2 = new string[] { "The_Tag_1_For_The_Second_User", "The_Tag_2_For_The_Second_User" };
        
        #region Object cache testing
        [Fact(DisplayName = "SetObject_OK")]
        [Trait(TraitName, TraitCacheObjectValue)]
        public void SetObject_OK()
        {                        
            var keys = new object[] { TheFirstUser.Id, TheLastUser.Id };
            RedisContext.Cache.RemoveKey<BsUserDTO>(keys);
            RedisContext.Cache.KeyExists<BsUserDTO>(CacheType.Object, TheFirstUser.Id).Should().BeFalse();
            RedisContext.Cache.KeyExists<BsUserDTO>(CacheType.Object, TheLastUser.Id).Should().BeFalse();
         
            RedisContext.Cache.SetObject<BsUserDTO>(TheFirstUser.Id, TheFirstUser);
            RedisContext.Cache.SetObject<BsUserDTO>(TheLastUser.Id, TheLastUser);
            RedisContext.Cache.KeyExists<BsUserDTO>(CacheType.Object, TheFirstUser.Id).Should().BeTrue();
            RedisContext.Cache.KeyExists<BsUserDTO>(CacheType.Object, TheLastUser.Id).Should().BeTrue();
        }

        [Fact(DisplayName = "GetObject_OK")]
        [Trait(TraitName, TraitCacheObjectValue)]
        public void GetObject_OK()
        {           
            var keys = new object[] { TheFirstUser.Id, TheLastUser.Id };
            RedisContext.Cache.RemoveKey<BsUserDTO>(keys);
            RedisContext.Cache.KeyExists<BsUserDTO>(CacheType.Object, TheFirstUser.Id).Should().BeFalse();
            RedisContext.Cache.KeyExists<BsUserDTO>(CacheType.Object, TheLastUser.Id).Should().BeFalse();

            RedisContext.Cache.SetObject<BsUserDTO>(TheFirstUser.Id, TheFirstUser);
            RedisContext.Cache.SetObject<BsUserDTO>(TheLastUser.Id, TheLastUser);
            RedisContext.Cache.KeyExists<BsUserDTO>(CacheType.Object, TheFirstUser.Id).Should().BeTrue();
            RedisContext.Cache.KeyExists<BsUserDTO>(CacheType.Object, TheLastUser.Id).Should().BeTrue();

            var firstCache = RedisContext.Cache.GetObject<BsUserDTO>(TheFirstUser.Id);
            var lastCache = RedisContext.Cache.GetObject<BsUserDTO>(TheLastUser.Id);
            firstCache.Should().NotBeNull();
            firstCache.Should().Equals(TheFirstUser);
            lastCache.Should().NotBeNull();
            lastCache.Should().Equals(TheLastUser);
        }

        [Fact(DisplayName = "GetObjectByTags_OK")]
        [Trait(TraitName, TraitCacheObjectValue)]
        public void GetObjectByTags_OK()
        {            
            RedisContext.Cache.RemoveTagsFromKey<BsUserDTO>(tags_1, CacheType.Object, TheFirstUser.Id);
            RedisContext.Cache.RemoveTagsFromKey<BsUserDTO>(tags_2, CacheType.Object, TheLastUser.Id);

            RedisContext.Cache.SetObject<BsUserDTO>(TheFirstUser.Id, TheFirstUser, tags_1);
            RedisContext.Cache.SetObject<BsUserDTO>(TheLastUser.Id, TheLastUser, tags_2);

            RedisContext.Cache.KeyExists<BsUserDTO>(CacheType.Object, TheFirstUser.Id).Should().BeTrue();
            RedisContext.Cache.KeyExists<BsUserDTO>(CacheType.Object, TheLastUser.Id).Should().BeTrue();

            var tags = tags_1.Union(tags_2).ToArray();
            var result = RedisContext.Cache.GetObjectsByTag<BsUserDTO>(tags).ToList();
            result.Should().NotBeNullOrEmpty();
            
            result.Where(x => x.Id == TheFirstUser.Id).Should().NotBeNullOrEmpty();
            result.Where(x => x.Id == TheLastUser.Id).Should().NotBeNullOrEmpty();
        }

        [Fact(DisplayName = "RemoveKey_Object_OK")]
        [Trait(TraitName, TraitCacheObjectValue)]
        public void RemoveKey_Object_OK()
        {
            RedisContext.Cache.SetObject<BsUserDTO>(TheFirstUser.Id, TheFirstUser);
            RedisContext.Cache.SetObject<BsUserDTO>(TheLastUser.Id, TheLastUser);
            RedisContext.Cache.KeyExists<BsUserDTO>(CacheType.Object, TheFirstUser.Id).Should().BeTrue();
            RedisContext.Cache.KeyExists<BsUserDTO>(CacheType.Object, TheLastUser.Id).Should().BeTrue();

            RedisContext.Cache.RemoveKey<BsUserDTO>(new object[] { TheFirstUser.Id, TheLastUser.Id });

            RedisContext.Cache.KeyExists<BsUserDTO>(CacheType.Object, TheFirstUser.Id).Should().BeFalse();
            RedisContext.Cache.KeyExists<BsUserDTO>(CacheType.Object, TheLastUser.Id).Should().BeFalse();
        }

        [Fact(DisplayName = "SetObject_With_Tag_OK")]
        [Trait(TraitName, TraitCacheObjectValue)]
        public void SetObject_With_Tag_OK()
        {
            RedisContext.Cache.RemoveTagsFromKey<BsUserDTO>(tags_1, CacheType.Object, TheFirstUser.Id);
            RedisContext.Cache.RemoveTagsFromKey<BsUserDTO>(tags_2, CacheType.Object, TheLastUser.Id);

            RedisContext.Cache.SetObject<BsUserDTO>(TheFirstUser.Id, TheFirstUser, tags_1);
            RedisContext.Cache.SetObject<BsUserDTO>(TheLastUser.Id, TheLastUser, tags_2);

            RedisContext.Cache.KeyExists<BsUserDTO>(CacheType.Object, TheFirstUser.Id).Should().BeTrue();
            RedisContext.Cache.KeyExists<BsUserDTO>(CacheType.Object, TheLastUser.Id).Should().BeTrue();           

            var redisKeys = RedisContext.Cache.GetRawKeysByTag(tags_1.Union(tags_2).ToArray(), CacheType.Object);
            var keys = new[] { TheFirstUser.Id.ToString(), TheLastUser.Id.ToString() };
            redisKeys.Should().Contain(keys);            
        }

        [Fact(DisplayName = "AddTagsToKey_Object_OK")]
        [Trait(TraitName, TraitCacheObjectValue)]
        public void AddTagsToKey_Object_OK()
        {             
            var keys = new object[] { TheFirstUser.Id, TheLastUser.Id };
            var tags = tags_1.Union(tags_2).ToArray();

            RedisContext.Cache.SetObject<BsUserDTO>(TheFirstUser.Id, TheFirstUser);
            RedisContext.Cache.SetObject<BsUserDTO>(TheLastUser.Id, TheLastUser);

            RedisContext.Cache.KeyExists<BsUserDTO>(CacheType.Object, TheFirstUser.Id).Should().BeTrue();
            RedisContext.Cache.KeyExists<BsUserDTO>(CacheType.Object, TheLastUser.Id).Should().BeTrue();

            // Remove tag for the key
            RedisContext.Cache.RemoveTagsFromKey<BsUserDTO>(tags_1, CacheType.Object, TheFirstUser.Id);
            RedisContext.Cache.RemoveTagsFromKey<BsUserDTO>(tags_2, CacheType.Object, TheLastUser.Id);

            //var redisKeys = RedisContext.Cache.GetKeysByTag(tags);
            var rawKeys = RedisContext.Cache.GetRawKeysByTag(tags);

            //TODO:
            // Assert
            RedisContext.Cache.GetAllTags().Should().NotContain(tags);

            // Add tags to the key
            RedisContext.Cache.AddTagsToKey<BsUserDTO>(tags_1, CacheType.Object, TheFirstUser.Id);
            RedisContext.Cache.AddTagsToKey<BsUserDTO>(tags_2, CacheType.Object, TheLastUser.Id);

            //TODO:
            // Assert the tags for the key should be contain in cache
            RedisContext.Cache.GetAllTags().Should().Contain(tags);
        }

        [Fact(DisplayName = "TryGetObject_OK")]
        [Trait(TraitName, TraitCacheObjectValue)]
        public void TryGetObject_OK()
        {
            RedisContext.Cache.SetObject<BsUserDTO>(TheFirstUser.Id, TheFirstUser);
            RedisContext.Cache.SetObject<BsUserDTO>(TheLastUser.Id, TheLastUser);
            BsUserDTO firstUserDTO;
            BsUserDTO lastUserDTO;
            RedisContext.Cache.TryGetObject<BsUserDTO>(TheFirstUser.Id, out firstUserDTO).Should().BeTrue();
            RedisContext.Cache.TryGetObject<BsUserDTO>(TheLastUser.Id, out lastUserDTO).Should().BeTrue();
            firstUserDTO.Should().NotBeNull();
            lastUserDTO.Should().NotBeNull();
        }

        [Fact(DisplayName = "RemoveTagsFromObjectKey_OK")]
        [Trait(TraitName, TraitCacheObjectValue)]
        public void RemoveTagsFromObjectKey_OK()
        {
            RedisContext.Cache.SetObject<BsUserDTO>(TheFirstUser.Id, TheFirstUser, tags_1);
            RedisContext.Cache.SetObject<BsUserDTO>(TheLastUser.Id, TheLastUser, tags_2);

            RedisContext.Cache.KeyExists<BsUserDTO>(CacheType.Object, TheFirstUser.Id).Should().BeTrue();
            RedisContext.Cache.KeyExists<BsUserDTO>(CacheType.Object, TheLastUser.Id).Should().BeTrue();

            RedisContext.Cache.RemoveTagsFromKey<BsUserDTO>(tags_1, CacheType.Object, TheFirstUser.Id);

            RedisContext.Cache.RemoveTagsFromKey<BsUserDTO>(tags_2, CacheType.Object, TheLastUser.Id);

            var tags = tags_1.Union(tags_2).ToArray();
            var redisKeys = RedisContext.Cache.GetKeysByTag(tags);

            var keys = new[] { TheFirstUser.Id, TheLastUser.Id };
            redisKeys.Should().NotContain(keys);
        }

        [Fact(DisplayName = "FetchObject_NoCacheHit_OK")]
        [Trait(TraitName, TraitCacheObjectValue)]
        public void FetchObject_NoCacheHit_OK()
        {
            var keys = new object[] { TheFirstUser.Id, TheLastUser.Id };
            RedisContext.Cache.RemoveKey<BsUserDTO>(keys);
            RedisContext.Cache.KeyExists<BsUserDTO>(CacheType.Object, TheFirstUser.Id).Should().BeFalse();
            RedisContext.Cache.KeyExists<BsUserDTO>(CacheType.Object, TheLastUser.Id).Should().BeFalse();
            int id1 = 10000;
            int id2 = 20000;
            int count = 0;

            // None cahe hit
            RedisContext.Cache.FetchObject<BsUserDTO>(TheFirstUser.Id, () => { count++; return new BsUserDTO() { Id = id1 }; });
            count.Should().Be(1);

            // Cache hit
            RedisContext.Cache.FetchObject<BsUserDTO>(TheFirstUser.Id, () => { count++; return new BsUserDTO() { Id = id1 }; });
            count.Should().Be(1);

            // None cahe hit
            RedisContext.Cache.FetchObject<BsUserDTO>(TheLastUser.Id, () => { count++; return new BsUserDTO() { Id = id2 }; });
            count.Should().Be(2);
            
            // Cache hit
            RedisContext.Cache.FetchObject<BsUserDTO>(TheLastUser.Id, () => { count++; return new BsUserDTO() { Id = id2 }; });
            count.Should().Be(2);

            RedisContext.Cache.KeyExists<BsUserDTO>(CacheType.Object, TheFirstUser.Id).Should().BeTrue();
            RedisContext.Cache.KeyExists<BsUserDTO>(CacheType.Object, TheLastUser.Id).Should().BeTrue();

            var firstCache = RedisContext.Cache.GetObject<BsUserDTO>(TheFirstUser.Id);
            var lastCache = RedisContext.Cache.GetObject<BsUserDTO>(TheLastUser.Id);

            firstCache.Should().NotBeNull();
            lastCache.Should().NotBeNull();
            firstCache.Id.Should().Equals(id1);
            lastCache.Id.Should().Equals(id2);
        }

        [Fact(DisplayName = "FetchObject_CacheHit_OK")]
        [Trait(TraitName, TraitCacheObjectValue)]
        public void FetchObject_CacheHit_OK()
        {
            RedisContext.Cache.SetObject<BsUserDTO>(TheFirstUser.Id, TheFirstUser);
            RedisContext.Cache.SetObject<BsUserDTO>(TheLastUser.Id, TheLastUser);

            int firstId = 10000;
            int lastId = 20000;
            int count = 0;

            // Cache hit
            RedisContext.Cache.FetchObject<BsUserDTO>(TheFirstUser.Id, () => { count++; return new BsUserDTO() { Id = firstId }; });
            // Cache hit
            RedisContext.Cache.FetchObject<BsUserDTO>(TheLastUser.Id, () => { count++; return new BsUserDTO() { Id = lastId }; });
            
            count.Should().Be(0);

            RedisContext.Cache.KeyExists<BsUserDTO>(CacheType.Object, TheFirstUser.Id).Should().BeTrue();
            RedisContext.Cache.KeyExists<BsUserDTO>(CacheType.Object, TheLastUser.Id).Should().BeTrue();            

            var firstCache = RedisContext.Cache.GetObject<BsUserDTO>(TheFirstUser.Id);
            var lastCache = RedisContext.Cache.GetObject<BsUserDTO>(TheLastUser.Id);

            firstCache.Should().NotBeNull();
            lastCache.Should().NotBeNull();
            firstCache.Id.Should().Equals(TheFirstUser.Id);
            lastCache.Id.Should().Equals(TheLastUser.Id);
        }

        [Fact(DisplayName = "FetchObjectWithTag_OK")]
        [Trait(TraitName, TraitCacheObjectValue)]
        public void FetchObjectWithTag_OK()
        {             
            int id1 = 10000;
            int id2 = 20000;
            var tag_10000 = new[] { "TAG_10000_1", "TAG_10000_2" };
            var tag_20000 = new[] { "TAG_20000_1", "TAG_20000_2" };

            var keys = new object[] { TheFirstUser.Id, TheLastUser.Id };
            RedisContext.Cache.RemoveTagsFromKey<BsUserDTO>(tag_10000, CacheType.Object, TheFirstUser.Id);
            RedisContext.Cache.RemoveTagsFromKey<BsUserDTO>(tag_20000, CacheType.Object, TheLastUser.Id);

            RedisContext.Cache.RemoveKey<BsUserDTO>(keys);
            RedisContext.Cache.KeyExists<BsUserDTO>(CacheType.Object, TheFirstUser.Id).Should().BeFalse();
            RedisContext.Cache.KeyExists<BsUserDTO>(CacheType.Object, TheLastUser.Id).Should().BeFalse();
                       
            RedisContext.Cache.GetAllTags().Should().NotContain(tag_10000.Union(tag_20000).ToArray());

            RedisContext.Cache.FetchObject<BsUserDTO>(TheFirstUser.Id, () => new BsUserDTO() { Id = id1 }, tag_10000);
            RedisContext.Cache.FetchObject<BsUserDTO>(TheLastUser.Id, () => new BsUserDTO() { Id = id2 }, tag_20000);
            RedisContext.Cache.KeyExists<BsUserDTO>(CacheType.Object, TheFirstUser.Id).Should().BeTrue();
            RedisContext.Cache.KeyExists<BsUserDTO>(CacheType.Object, TheLastUser.Id).Should().BeTrue();

            var firstCache = RedisContext.Cache.GetObject<BsUserDTO>(TheFirstUser.Id);
            var lastCache = RedisContext.Cache.GetObject<BsUserDTO>(TheLastUser.Id);

            firstCache.Should().NotBeNull();
            lastCache.Should().NotBeNull();
            firstCache.Id.Should().Equals(id1);
            lastCache.Id.Should().Equals(id2);

            RedisContext.Cache.GetAllTags().Should().Contain(tag_10000.Union(tag_20000).ToArray());
        }

        [Fact(DisplayName = "FetchObjectWithTagBuilder_OK")]
        [Trait(TraitName, TraitCacheObjectValue)]
        public void FetchObjectWithTagBuilder_OK()
        {
            var keys = new object[] { TheFirstUser.Id, TheLastUser.Id };

            int firstId = 10000;
            int lastId = 20000;
            var tag_10000 = new[] { "TAG_10000_1", "TAG_10000_2" };
            var tag_20000 = new[] { "TAG_20000_1", "TAG_20000_2" };

            RedisContext.Cache.RemoveTagsFromKey<BsUserDTO>(tag_10000, CacheType.Object, TheFirstUser.Id);
            RedisContext.Cache.RemoveTagsFromKey<BsUserDTO>(tag_20000, CacheType.Object, TheLastUser.Id);
            RedisContext.Cache.RemoveKey<BsUserDTO>(keys);
            RedisContext.Cache.KeyExists<BsUserDTO>(CacheType.Object, TheFirstUser.Id).Should().BeFalse();
            RedisContext.Cache.KeyExists<BsUserDTO>(CacheType.Object, TheLastUser.Id).Should().BeFalse();
            
            RedisContext.Cache.GetAllTags().Should().NotContain(tag_10000.Union(tag_20000).ToArray());

            RedisContext.Cache.FetchObject<BsUserDTO>(TheFirstUser.Id, () => new BsUserDTO() { Id = firstId }, x => new[] { string.Format("TAG_{0}_1", x.Id), string.Format("TAG_{0}_2", x.Id) });

            RedisContext.Cache.FetchObject<BsUserDTO>(TheLastUser.Id, () => new BsUserDTO() { Id = lastId }, x => new[] { string.Format("TAG_{0}_1", x.Id), string.Format("TAG_{0}_2", x.Id) });
            RedisContext.Cache.KeyExists<BsUserDTO>(CacheType.Object, TheFirstUser.Id).Should().BeTrue();
            RedisContext.Cache.KeyExists<BsUserDTO>(CacheType.Object, TheLastUser.Id).Should().BeTrue();

            var firstCache = RedisContext.Cache.GetObject<BsUserDTO>(TheFirstUser.Id);
            var lastCache = RedisContext.Cache.GetObject<BsUserDTO>(TheLastUser.Id);

            firstCache.Should().NotBeNull();
            lastCache.Should().NotBeNull();
            firstCache.Id.Should().Equals(firstId);
            lastCache.Id.Should().Equals(lastId);

            RedisContext.Cache.GetAllTags().Should().Contain(tag_10000.Union(tag_20000).ToArray());
        }
        #endregion        

        #region Hashed cache testing
        [Fact(DisplayName = "SetHashed_OK")]
        [Trait(TraitName, TraitCacheHashedValue)]
        public void SetHashed_OK()
        {
            RedisContext.Cache.RemoveKey<BsUserDTO>();
            RedisContext.Cache.KeyExists<BsUserDTO>().Should().BeFalse();
            IDictionary<object, BsUserDTO> fieldValues = new Dictionary<object, BsUserDTO>();
            AllUsers.ToList().ForEach(x =>
            {
                fieldValues.Add(x.Id, x);
            });
            RedisContext.Cache.SetHashed<BsUserDTO>(fieldValues);
            RedisContext.Cache.KeyExists<BsUserDTO>().Should().BeTrue();
        }

        [Fact(DisplayName = "GetHash_OK")]
        [Trait(TraitName, TraitCacheHashedValue)]
        public void GetHash_OK()
        {
            RedisContext.Cache.RemoveKey<BsUserDTO>();
            RedisContext.Cache.KeyExists<BsUserDTO>().Should().BeFalse();
            IDictionary<object, BsUserDTO> fieldValues = new Dictionary<object, BsUserDTO>();
            AllUsers.ToList().ForEach(x =>
            {
                fieldValues.Add(x.Id, x);
            });
            RedisContext.Cache.SetHashed<BsUserDTO>(fieldValues);
            RedisContext.Cache.KeyExists<BsUserDTO>().Should().BeTrue();

            var theFirstUser = RedisContext.Cache.GetHashed<BsUserDTO>(TheFirstUser.Id);
            var theLastUser = RedisContext.Cache.GetHashed<BsUserDTO>(TheLastUser.Id);
            theFirstUser.Should().NotBeNull();
            theFirstUser.Should().Equals(TheFirstUser);
            theLastUser.Should().NotBeNull();
            theLastUser.Should().Equals(TheLastUser);
        }

        [Fact(DisplayName = "GetHashByTags_OK")]
        [Trait(TraitName, TraitCacheHashedValue)]
        public void GetHashByTags_OK()
        {
            //RedisContext.Cache.RemoveTagsFromHashField<BsUserDTO>(TheFirstUser.Id, tags_1);
            //RedisContext.Cache.RemoveTagsFromHashField<BsUserDTO>(TheLastUser.Id, tags_2);

            //RedisContext.Cache.SetHashed<BsUserDTO>(TheFirstUser.Id, TheFirstUser, tags_1);
            //RedisContext.Cache.SetHashed<BsUserDTO>(TheLastUser.Id, TheLastUser, tags_2);

            //RedisContext.Cache.KeyExists<BsUserDTO>().Should().BeTrue();

            //var tags = tags_1.Union(tags_2).ToArray();
            //var theFirstUser = RedisContext.Cache.GetHashed<BsUserDTO>(TheFirstUser.Id);
            //theFirstUser.Should().NotBeNull();
            //theFirstUser.Should().Equals(TheFirstUser);
        }

        [Fact(DisplayName = "RemoveHashed_OK")]
        [Trait(TraitName, TraitCacheHashedValue)]
        public void RemoveHashed_OK()
        {
            RedisContext.Cache.RemoveKey<BsUserDTO>();
            RedisContext.Cache.KeyExists<BsUserDTO>().Should().BeFalse();
            IDictionary<object, BsUserDTO> fieldValues = new Dictionary<object, BsUserDTO>();
            AllUsers.ToList().ForEach(x =>
            {
                fieldValues.Add(x.Id, x);
            });
            RedisContext.Cache.SetHashed<BsUserDTO>(fieldValues);
            RedisContext.Cache.KeyExists<BsUserDTO>().Should().BeTrue();

            RedisContext.Cache.RemoveHashed<BsUserDTO>(TheFirstUser.Id);
            RedisContext.Cache.RemoveHashed<BsUserDTO>(TheLastUser.Id);

            var theFirstUser = RedisContext.Cache.GetHashed<BsUserDTO>(TheFirstUser.Id);
            var theLastUser = RedisContext.Cache.GetHashed<BsUserDTO>(TheLastUser.Id);
            theFirstUser.Should().BeNull();
            theLastUser.Should().BeNull();
        }

        [Fact(DisplayName = "SetHash_With_Tag_OK")]
        [Trait(TraitName, TraitCacheHashedValue)]
        public void SetHash_With_Tag_OK()
        {
            var tags = tags_1.Union(tags_2).ToArray();

            RedisContext.Cache.RemoveTagsFromHashField<BsUserDTO>(TheFirstUser.Id, tags_1);
            RedisContext.Cache.RemoveTagsFromHashField<BsUserDTO>(TheLastUser.Id, tags_2);

            RedisContext.Cache.GetRawKeysByTag(tags).Should().NotContain(new[] { "BsUser:hash" });

            RedisContext.Cache.SetHashed<BsUserDTO>(TheFirstUser.Id, TheFirstUser, tags_1);
            RedisContext.Cache.SetHashed<BsUserDTO>(TheLastUser.Id, TheLastUser, tags_2);

            RedisContext.Cache.KeyExists<BsUserDTO>().Should().BeTrue();
            
            var result = RedisContext.Cache.GetRawKeysByTag(tags);
            result.Should().NotBeNullOrEmpty();

            result.Should().Contain(new[] { "BsUser:hash" });
        }

        [Fact(DisplayName = "AddTagsToKey_Hashed_OK")]
        [Trait(TraitName, TraitCacheHashedValue)]
        public void AddTagsToKey_Hashed_OK()
        {
            var keys = new object[] { TheFirstUser.Id, TheLastUser.Id };
            var tags = tags_1.Union(tags_2).ToArray();

            RedisContext.Cache.SetHashed<BsUserDTO>(TheFirstUser.Id, TheFirstUser);
            RedisContext.Cache.SetHashed<BsUserDTO>(TheLastUser.Id, TheLastUser);

            RedisContext.Cache.KeyExists<BsUserDTO>().Should().BeTrue();

            // Remove tag for the key
            RedisContext.Cache.RemoveTagsFromKey<BsUserDTO>(tags);

            //var redisKeys = RedisContext.Cache.GetKeysByTag(tags);
            //var rawKeys = RedisContext.Cache.GetRawKeysByTag(tags);

            // TODO:
            // Assert
            RedisContext.Cache.GetAllTags().Should().NotContain(tags);

            // Add tags to the key
            RedisContext.Cache.AddTagsToKey<BsUsageDTO>(tags_1);

            // TODO:
            // Assert the tags for the key should be contain in cache
            RedisContext.Cache.GetAllTags().Should().Contain(tags);
        }

        //[Fact]
        //[Trait(TraitName, TraitCacheHashedValue)]
        //public void AddTagsToHashField_OK()
        //{
        //    var users = CallService((IBsUserService x) => x.GetAll());
        //    users.Should().NotBeNullOrEmpty();

        //    var first = users.First();
        //    var last = users.Last();
        //    first.Should().NotBeNull();
        //    last.Should().NotBeNull();

        //    var keys = new object[] { first.Id, last.Id };
        //    var tags = tags_1.Union(tags_2).ToArray();

        //    redisContext.Cache.SetHashed<BsUserDTO>(first.Id, first);
        //    redisContext.Cache.SetHashed<BsUserDTO>(last.Id, last);

        //    redisContext.Cache.KeyExists<BsUserDTO>().Should().BeTrue();

        //    // Remove tag for the key
        //    redisContext.Cache.RemoveTagsFromKey<BsUserDTO>(tags_1);
        //    redisContext.Cache.RemoveTagsFromKey<BsUserDTO>(tags_2);

        //    // Assert
        //    redisContext.Cache.GetAllTags().Should().NotContain(tags);

        //    // Add tags to the key
        //    redisContext.Cache.AddTagsToKey<BsUserDTO>(first.Id, tags_1);
        //    redisContext.Cache.AddTagsToKey<BsUserDTO>(last.Id, tags_2);

        //    // Assert the tags for the key should be contain in cache
        //    redisContext.Cache.GetAllTags().Should().Contain(tags);
        //}
        #endregion

        [Fact]
        public void TEST()
        {
            var keys = RedisContext.Cache.GetKeysByTag(new[] { "The_Tag_1_For_The_First_User"});
            var rowKeys = RedisContext.Cache.GetRawKeysByTag(new[] { "The_Tag_1_For_The_First_User" }).Distinct();
        }
    }
}
