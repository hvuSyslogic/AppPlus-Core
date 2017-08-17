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
    public partial class RedisCacheUnitTests : TestBase
    {
        private const string TraitName = "RedisCacheUnitTests";
        private const string TraitValue = "Cache Object";
        private static readonly IRedisContext redisContext = IoCManager.Container.Resolve<IRedisContext>();
        private string[] tags_1 = new string[] { "The_Tag_1_For_The_First_User", "The_Tag_2_For_The_First_User" };
        private string[] tags_2 = new string[] { "The_Tag_1_For_The_Second_User", "The_Tag_2_For_The_Second_User" };
        
        #region Object cache testing
        [Fact]
        [Trait(TraitName, TraitValue)]
        public void SetObject_OK()
        {
            var users = CallService((IBsUserService x) => x.GetAll());
            users.Should().NotBeNullOrEmpty();

            var first = users.First();
            var last = users.Last();
            first.Should().NotBeNull();
            last.Should().NotBeNull();
            
            var keys = new object[] { first.Id, last.Id };
            redisContext.Cache.Remove<BsUserDTO>(keys);
            redisContext.Cache.KeyExists<BsUserDTO>(first.Id).Should().BeFalse();
            redisContext.Cache.KeyExists<BsUserDTO>(last.Id).Should().BeFalse();
         
            redisContext.Cache.SetObject<BsUserDTO>(first.Id, first);
            redisContext.Cache.SetObject<BsUserDTO>(last.Id, last);
            redisContext.Cache.KeyExists<BsUserDTO>(first.Id).Should().BeTrue();
            redisContext.Cache.KeyExists<BsUserDTO>(last.Id).Should().BeTrue();
        }

        [Fact]
        [Trait(TraitName, TraitValue)]
        public void GetObjectA_OK()
        {
            var users = CallService((IBsUserService x) => x.GetAll());
            users.Should().NotBeNullOrEmpty();

            var first = users.First();
            var last = users.Last();
            first.Should().NotBeNull();
            last.Should().NotBeNull();

            var keys = new object[] { first.Id, last.Id };
            redisContext.Cache.Remove<BsUserDTO>(keys);
            redisContext.Cache.KeyExists<BsUserDTO>(first.Id).Should().BeFalse();
            redisContext.Cache.KeyExists<BsUserDTO>(last.Id).Should().BeFalse();

            redisContext.Cache.SetObject<BsUserDTO>(first.Id, first);
            redisContext.Cache.SetObject<BsUserDTO>(last.Id, last);
            redisContext.Cache.KeyExists<BsUserDTO>(first.Id).Should().BeTrue();
            redisContext.Cache.KeyExists<BsUserDTO>(last.Id).Should().BeTrue();

            var firstCache = redisContext.Cache.GetObjectA<BsUserDTO>(first.Id);
            var lastCache = redisContext.Cache.GetObjectA<BsUserDTO>(last.Id);
            firstCache.Should().NotBeNull();
            firstCache.Should().Equals(first);
            lastCache.Should().NotBeNull();
            lastCache.Should().Equals(last);
        }

        [Fact]
        [Trait(TraitName, TraitValue)]
        public void GetObjectByTags_OK()
        {
            var users = CallService((IBsUserService x) => x.GetAll());
            users.Should().NotBeNullOrEmpty();

            var first = users.First();
            var last = users.Last();
            first.Should().NotBeNull();
            last.Should().NotBeNull();

            redisContext.Cache.RemoveTagsFromKey<BsUserDTO>(first.Id, tags_1);
            redisContext.Cache.RemoveTagsFromKey<BsUserDTO>(last.Id, tags_2);

            redisContext.Cache.SetObject<BsUserDTO>(first.Id, first, tags_1);
            redisContext.Cache.SetObject<BsUserDTO>(last.Id, last, tags_2);

            redisContext.Cache.KeyExists<BsUserDTO>(first.Id).Should().BeTrue();
            redisContext.Cache.KeyExists<BsUserDTO>(last.Id).Should().BeTrue();

            var tags = tags_1.Union(tags_2).ToArray();
            var result = redisContext.Cache.GetObjectsByTag<BsUserDTO>(tags).ToList();
            result.Should().NotBeNullOrEmpty();
            
            result.Where(x => x.Id == first.Id).Should().NotBeNullOrEmpty();
            result.Where(x => x.Id == last.Id).Should().NotBeNullOrEmpty();
        }

        [Fact]
        [Trait(TraitName, TraitValue)]
        public void RemoveObject_OK()
        {
            var users = CallService((IBsUserService x) => x.GetAll());
            users.Should().NotBeNullOrEmpty();

            var first = users.First();
            var last = users.Last();
            first.Should().NotBeNull();
            last.Should().NotBeNull();

            redisContext.Cache.SetObject<BsUserDTO>(first.Id, first);
            redisContext.Cache.SetObject<BsUserDTO>(last.Id, last);
            redisContext.Cache.KeyExists<BsUserDTO>(first.Id).Should().BeTrue();
            redisContext.Cache.KeyExists<BsUserDTO>(last.Id).Should().BeTrue();

            redisContext.Cache.Remove<BsUserDTO>(new object[] { first.Id, last.Id });

            redisContext.Cache.KeyExists<BsUserDTO>(first.Id).Should().BeFalse();
            redisContext.Cache.KeyExists<BsUserDTO>(last.Id).Should().BeFalse();
        }        

        [Fact]
        [Trait(TraitName, TraitValue)]
        public void SetObject_With_Tag_OK()
        {
            var users = CallService((IBsUserService x) => x.GetAll());
            users.Should().NotBeNullOrEmpty();

            var first = users.First();
            var last = users.Last();
            first.Should().NotBeNull();
            last.Should().NotBeNull();

            redisContext.Cache.RemoveTagsFromKey<BsUserDTO>(first.Id, tags_1);
            redisContext.Cache.RemoveTagsFromKey<BsUserDTO>(last.Id, tags_2);

            redisContext.Cache.SetObject<BsUserDTO>(first.Id, first, tags_1);
            redisContext.Cache.SetObject<BsUserDTO>(last.Id, last, tags_2);

            redisContext.Cache.KeyExists<BsUserDTO>(first.Id).Should().BeTrue();
            redisContext.Cache.KeyExists<BsUserDTO>(last.Id).Should().BeTrue();           

            var redisKeys = redisContext.Cache.GetKeysByTagA(tags_1.Union(tags_2).ToArray());
            var keys = new[] { first.Id.ToString(), last.Id.ToString() };
            redisKeys.Should().Contain(keys);            
        }

        [Fact]
        [Trait(TraitName, TraitValue)]
        public void AddTagsToKey_OK()
        {            
            var users = CallService((IBsUserService x) => x.GetAll());
            users.Should().NotBeNullOrEmpty();

            var first = users.First();
            var last = users.Last();
            first.Should().NotBeNull();
            last.Should().NotBeNull();
            
            var keys = new[] { first.Id, last.Id };
            var tags = tags_1.Union(tags_2).ToArray();

            redisContext.Cache.SetObject<BsUserDTO>(first.Id, first);
            redisContext.Cache.SetObject<BsUserDTO>(last.Id, last);

            redisContext.Cache.KeyExists<BsUserDTO>(first.Id).Should().BeTrue();
            redisContext.Cache.KeyExists<BsUserDTO>(last.Id).Should().BeTrue();

            // Remove tag for the key
            redisContext.Cache.RemoveTagsFromKey<BsUserDTO>(first.Id, tags_1);
            redisContext.Cache.RemoveTagsFromKey<BsUserDTO>(last.Id, tags_2);                       

            // Assert
            redisContext.Cache.GetAllTags().Should().NotContain(tags);

            // Add tags to the key
            redisContext.Cache.AddTagsToKey(first.Id.ToString(), tags_1);
            redisContext.Cache.AddTagsToKey(last.Id.ToString(), tags_2);

            // Assert the tags for the key should be contain in cache
            redisContext.Cache.GetAllTags().Should().Contain(tags);
        }        

        [Fact]
        [Trait(TraitName, TraitValue)]
        public void TryGetObject_OK()
        {
            redisContext.Cache.FlushAll();

            var users = CallService((IBsUserService x) => x.GetAll());
            users.Should().NotBeNullOrEmpty();

            var first = users.First();
            var last = users.Last();
            first.Should().NotBeNull();
            last.Should().NotBeNull();

            redisContext.Cache.SetObject<BsUserDTO>(first.Id, first);
            redisContext.Cache.SetObject<BsUserDTO>(last.Id, last);
            BsUserDTO firstUserDTO;
            BsUserDTO lastUserDTO;
            redisContext.Cache.TryGetObject<BsUserDTO>(first.Id, out firstUserDTO).Should().BeTrue();
            redisContext.Cache.TryGetObject<BsUserDTO>(last.Id, out lastUserDTO).Should().BeTrue();
            firstUserDTO.Should().NotBeNull();
            lastUserDTO.Should().NotBeNull();
        }

        [Fact]
        [Trait(TraitName, TraitValue)]
        public void RemoveTagsFromKey_From_Object_OK()
        {
            redisContext.Cache.FlushAll();

            var users = CallService((IBsUserService x) => x.GetAll());
            users.Should().NotBeNullOrEmpty();

            var first = users.First();
            var last = users.Last();
            first.Should().NotBeNull();
            last.Should().NotBeNull();
        
            redisContext.Cache.SetObject<BsUserDTO>(first.Id, first, tags_1);
            redisContext.Cache.SetObject<BsUserDTO>(last.Id, last, tags_2);

            redisContext.Cache.KeyExists<BsUserDTO>(first.Id).Should().BeTrue();
            redisContext.Cache.KeyExists<BsUserDTO>(last.Id).Should().BeTrue();

            redisContext.Cache.RemoveTagsFromKey<BsUserDTO>(first.Id, tags_1);
            
            redisContext.Cache.RemoveTagsFromKey<BsUserDTO>(last.Id, tags_2);

            var tags = tags_1.Union(tags_2).ToArray();
            var redisKeys = redisContext.Cache.GetKeysByTagA(tags);

            var keys = new[] { first.Id, last.Id };
            redisKeys.Should().NotContain(keys);            
        }

        [Fact]
        [Trait(TraitName, TraitValue)]
        public void FetchObject_None_Hit_Cache_OK()
        {
            var users = CallService((IBsUserService x) => x.GetAll());
            users.Should().NotBeNullOrEmpty();

            var first = users.First();
            var last = users.Last();
            first.Should().NotBeNull();
            last.Should().NotBeNull();

            var keys = new object[] { first.Id, last.Id };
            redisContext.Cache.Remove<BsUserDTO>(keys);
            redisContext.Cache.KeyExists<BsUserDTO>(first.Id).Should().BeFalse();
            redisContext.Cache.KeyExists<BsUserDTO>(last.Id).Should().BeFalse();
            int id1 = 10000;
            int id2 = 20000;
            redisContext.Cache.FetchObject<BsUserDTO>(first.Id, () => { return new BsUserDTO() { Id = id1 }; });
            redisContext.Cache.FetchObject<BsUserDTO>(last.Id, () => { return new BsUserDTO() { Id = id2 }; });
            redisContext.Cache.KeyExists<BsUserDTO>(first.Id).Should().BeTrue();
            redisContext.Cache.KeyExists<BsUserDTO>(last.Id).Should().BeTrue();

            var firstCache = redisContext.Cache.GetObjectA<BsUserDTO>(first.Id);
            var lastCache = redisContext.Cache.GetObjectA<BsUserDTO>(last.Id);

            firstCache.Should().NotBeNull();
            lastCache.Should().NotBeNull();
            firstCache.Id.Should().Equals(id1);
            lastCache.Id.Should().Equals(id2);
        }

        [Fact]
        [Trait(TraitName, TraitValue)]
        public void FetchObject_Hit_Cache_OK()
        {
            var users = CallService((IBsUserService x) => x.GetAll());
            users.Should().NotBeNullOrEmpty();

            var first = users.First();
            var last = users.Last();
            first.Should().NotBeNull();
            last.Should().NotBeNull();

            redisContext.Cache.SetObject<BsUserDTO>(first.Id, first);
            redisContext.Cache.SetObject<BsUserDTO>(last.Id, last);

            int id1 = 10000;
            int id2 = 20000;
            redisContext.Cache.FetchObject<BsUserDTO>(first.Id, () => { return new BsUserDTO() { Id = id1 }; });
            redisContext.Cache.FetchObject<BsUserDTO>(last.Id, () => { return new BsUserDTO() { Id = id2 }; });
            redisContext.Cache.KeyExists<BsUserDTO>(first.Id).Should().BeTrue();
            redisContext.Cache.KeyExists<BsUserDTO>(last.Id).Should().BeTrue();

            var firstCache = redisContext.Cache.GetObjectA<BsUserDTO>(first.Id);
            var lastCache = redisContext.Cache.GetObjectA<BsUserDTO>(last.Id);

            firstCache.Should().NotBeNull();
            lastCache.Should().NotBeNull();
            firstCache.Id.Should().Equals(first.Id);
            lastCache.Id.Should().Equals(last.Id);
        }

        [Fact]
        [Trait(TraitName, TraitValue)]
        public void FetchObjectWithTag_OK()
        {
            var users = CallService((IBsUserService x) => x.GetAll());
            users.Should().NotBeNullOrEmpty();

            var first = users.First();
            var last = users.Last();
            first.Should().NotBeNull();
            last.Should().NotBeNull();
             
            int id1 = 10000;
            int id2 = 20000;
            var tag_10000 = new[] { "TAG_10000_1", "TAG_10000_2" };
            var tag_20000 = new[] { "TAG_20000_1", "TAG_20000_2" };

            var keys = new object[] { first.Id, last.Id };
            redisContext.Cache.RemoveTagsFromKey(first.Id.ToString(), tag_10000);
            redisContext.Cache.RemoveTagsFromKey(last.Id.ToString(), tag_20000);

            redisContext.Cache.Remove<BsUserDTO>(keys);
            redisContext.Cache.KeyExists<BsUserDTO>(first.Id).Should().BeFalse();
            redisContext.Cache.KeyExists<BsUserDTO>(last.Id).Should().BeFalse();
           
            
            redisContext.Cache.GetAllTags().Should().NotContain(tag_10000.Union(tag_20000).ToArray());

            redisContext.Cache.FetchObject<BsUserDTO>(first.Id, () => new BsUserDTO() { Id = id1 }, tag_10000);
            redisContext.Cache.FetchObject<BsUserDTO>(last.Id, () => new BsUserDTO() { Id = id2 }, tag_20000);
            redisContext.Cache.KeyExists<BsUserDTO>(first.Id).Should().BeTrue();
            redisContext.Cache.KeyExists<BsUserDTO>(last.Id).Should().BeTrue();

            var firstCache = redisContext.Cache.GetObjectA<BsUserDTO>(first.Id);
            var lastCache = redisContext.Cache.GetObjectA<BsUserDTO>(last.Id);

            firstCache.Should().NotBeNull();
            lastCache.Should().NotBeNull();
            firstCache.Id.Should().Equals(id1);
            lastCache.Id.Should().Equals(id2);

            redisContext.Cache.GetAllTags().Should().Contain(tag_10000.Union(tag_20000).ToArray());
        }

        [Fact]
        [Trait(TraitName, TraitValue)]
        public void FetchObjectWithTagBuilder_OK()
        {
            var users = CallService((IBsUserService x) => x.GetAll());
            users.Should().NotBeNullOrEmpty();

            var first = users.First();
            var last = users.Last();
            first.Should().NotBeNull();
            last.Should().NotBeNull();

            var keys = new object[] { first.Id, last.Id };

            int id1 = 10000;
            int id2 = 20000;
            var tag_10000 = new[] { "TAG_10000_1", "TAG_10000_2" };
            var tag_20000 = new[] { "TAG_20000_1", "TAG_20000_2" };

            redisContext.Cache.RemoveTagsFromKey<BsUserDTO>(first.Id.ToString(), tag_10000);
            redisContext.Cache.RemoveTagsFromKey<BsUserDTO>(last.Id.ToString(), tag_20000);
            redisContext.Cache.Remove<BsUserDTO>(keys);
            redisContext.Cache.KeyExists<BsUserDTO>(first.Id).Should().BeFalse();
            redisContext.Cache.KeyExists<BsUserDTO>(last.Id).Should().BeFalse();
            
            redisContext.Cache.GetAllTags().Should().NotContain(tag_10000.Union(tag_20000).ToArray());

            redisContext.Cache.FetchObject<BsUserDTO>(first.Id, () => new BsUserDTO() { Id = id1 }, x => new[] { string.Format("TAG_{0}_1", x.Id), string.Format("TAG_{0}_2", x.Id) });

            redisContext.Cache.FetchObject<BsUserDTO>(last.Id, () => new BsUserDTO() { Id = id2 }, x => new[] { string.Format("TAG_{0}_1", x.Id), string.Format("TAG_{0}_2", x.Id) });
            redisContext.Cache.KeyExists<BsUserDTO>(first.Id).Should().BeTrue();
            redisContext.Cache.KeyExists<BsUserDTO>(last.Id).Should().BeTrue();

            var firstCache = redisContext.Cache.GetObjectA<BsUserDTO>(first.Id);
            var lastCache = redisContext.Cache.GetObjectA<BsUserDTO>(last.Id);

            firstCache.Should().NotBeNull();
            lastCache.Should().NotBeNull();
            firstCache.Id.Should().Equals(id1);
            lastCache.Id.Should().Equals(id2);

            redisContext.Cache.GetAllTags().Should().Contain(tag_10000.Union(tag_20000).ToArray());
        }
        #endregion        

        #region To Be Deleted
        //[Fact(DisplayName = "SetHashed_Test_OK")]
        //[Trait(TraitName, TraitValue)]
        //public void SetHashed_Test_OK()
        //{
        //    var users = CallService((IBsUserService x) => x.GetAll()).ToList();
        //    users.ForEach(x => SetHashedToCache(redisContext, x, new[] { string.Format("BsUserDTO:Code:{0}", x.Code), string.Format("BsUserDTO:Name:{0}", x.Name) }));
        //}

        //[Fact]
        //public void GetAllTags()
        //{
        //    var tags = redisContext.Cache.GetAllTags().ToList();
        //    tags.Should().NotBeNullOrEmpty();
        //}

        //[Fact]
        //public void Get()
        //{
        //    var keys = redisContext.Cache.GetKeysByTagA(new[] { string.Format("BsUserDTO:Code:999999", ""), "BsUserDTO:Name:蔡华琼" }).ToList();
        //    keys.Should().NotBeNullOrEmpty();

        //    var first = redisContext.Cache.GetHashed<BsUserDTO>(keys.First());
        //    first.Should().NotBeNull();
        //    var last = redisContext.Cache.GetHashed<BsUserDTO>(keys.Last());
        //    last.Should().NotBeNull();
        //}

        //[Fact]
        //public void GetHashed_Test()
        //{
        //    var keys = redisContext.Cache.GetKeysByTag(new[] { "BsUserDTO:Code:999999" });
        //    keys.Should().NotBeNullOrEmpty();

        //    var user = redisContext.Cache.GetHashed<BsUserDTO>(9);

        //    //var user = redisContext.Cache.GetObjectsByTag<BsUserDTO>("9").ToList();
        //    //user.Should().NotBeNullOrEmpty();
        //}

        //private void SetHashedToCache<T>(IRedisContext context, T o, string[] tags) where T : DtoBase<int>
        //{
        //    context.Cache.SetHashed(o.Id, o, tags);
        //}

        //[Fact(DisplayName = "GetHashed_Test_OK")]
        //[Trait(TraitName, TraitValue)]
        //public void GetHashed_Test_OK()
        //{
        //    var location = redisContext.Cache.GetHashed<BsLocationDTO>(1655);
        //    location.Should().NotBeNull();
        //    redisContext.Cache.AddTagsToKey("111", new[] { "aaaa" });
        //    //IDictionary<string, BsItemDTO> items = await redisContext.Cache.GetHashedAllAsync<BsItemDTO>("items:hash");

        //    //IDictionary<string, BsLocationDTO> result = await redisContext.Cache.GetHashedAllAsync<BsLocationDTO>("locations:hash");

        //    //var scan = redisContext.Cache.ScanHashed<BsLocationDTO>("locations:hash", "location:id:15*");
        //    //var a = scan.Where(x => x.Value.Id == 1574).FirstOrDefault();
        //    //var v = scan.Where(x => x.Value.Id == 1608).FirstOrDefault();

        //    //var scan1 = redisContext.Cache.ScanHashed<BsItemDTO>("items:hash", "item:*");
        //    //var aaa = scan1.Where(x => x.Value.Id == 847684).FirstOrDefault();            
        //}

        //[Fact(DisplayName = "GetObject_Test_OK", Skip = "true")]
        //[Trait(TraitName, TraitValue)]
        //public void GetObject_Test_OK()
        //{
        //    var location = redisContext.Cache.GetObjectA<BsLocationDTO>(1655);
        //    location.Should().NotBeNull();
        //}

        //[Fact]
        //public void GetByTag()
        //{
        //    var location = redisContext.Cache.GetKeysByTag(new[] { "101", "aaaa" }).ToArray();

        //    var loc1 = redisContext.Cache.GetObjectsByTag<BsLocationDTO>("1655").ToList();
        //    var loc2 = redisContext.Cache.GetObjectsByTag<BsLocationDTO>("101").ToList();

        //}


        //[Fact]
        //public void AddTagsToHashField_Test()
        //{
        //    string[] tags = new[] { "AddTagsToHashField_Test-1", "AddTagsToHashField_Test-2" };
        //    redisContext.Cache.AddTagsToHashField<BsLocationDTO>(856, tags);

        //    redisContext.Cache.GetAllTags().Should().Contain(tags[0]);
        //}

        //[Fact(DisplayName = "FetchHashed_Test_OK")]
        //[Trait(TraitName, TraitValue)]
        //public void FetchHashed_Test_OK()
        //{
        //    var locationId = 908;
        //    Func<BsLocationDTO> func = () => CallService((IBsLocationService x) => x.GetById(locationId));
        //    var location = redisContext.Cache.FetchHashed<BsLocationDTO>(locationId, func);
        //    location.Should().NotBeNull();
        //    location.Id.Should().Equals(locationId);

        //    var itemId = 334247;
        //    var item = redisContext.Cache.FetchHashed<BsItemDTO>(itemId, () => CallService((IBsItemService x) => x.GetById(itemId)));
        //    item.Should().NotBeNull();
        //    item.Id.Should().Equals(itemId);
        //}

        //[Fact(DisplayName = "TryGetHashed_Test_OK")]
        //[Trait(TraitName, TraitValue)]
        //public void TryGetHashed_Test_OK()
        //{
        //    BsLocationDTO value;
        //    int id = 830;
        //    bool result = redisContext.Cache.TryGetHashed<BsLocationDTO>(id, out value);
        //    result.Should().BeTrue();
        //    value.Should().NotBeNull();
        //}

        //[Fact(DisplayName = "FetchObject_Test_OK")]
        //[Trait(TraitName, TraitValue)]
        //public void FetchObject_Test_OK()
        //{
        //    int id = 830;
        //    var location = redisContext.Cache.FetchObject<BsLocationDTO>(id, () => CallService((IBsLocationService x) => x.GetById(id)));
        //    location.Should().NotBeNull();

        //    id = 828;
        //    location = redisContext.Cache.FetchObject<BsLocationDTO>(id, () => CallService((IBsLocationService x) => x.GetById(id)));
        //    location.Should().NotBeNull();
        //}
        #endregion
    }
}
