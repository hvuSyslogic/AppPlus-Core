using HisPlus.Contract.Messages;
using HisPlus.Contract.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentAssertions;
using Xunit;
using HisPlus.Infrastructure.Extensions;
using HisPlus.Redis;

namespace HisPlus.UnitTesting.Redis
{
    public partial class CacheFrameworkUnitTests
    {
        [Fact(DisplayName = "GetHashed_Test_OK")]
        [Trait(TraitName, TraitValue)]
        public void GetHashed_Test_OK()
        {            
            var location = redisContext.Cache.GetHashed<BsLocationDTO>(1655);
            location.Should().NotBeNull(); 
            redisContext.Cache.AddTagsToKey("111", new[] { "aaaa" });
            //IDictionary<string, BsItemDTO> items = await redisContext.Cache.GetHashedAllAsync<BsItemDTO>("items:hash");

            //IDictionary<string, BsLocationDTO> result = await redisContext.Cache.GetHashedAllAsync<BsLocationDTO>("locations:hash");

            //var scan = redisContext.Cache.ScanHashed<BsLocationDTO>("locations:hash", "location:id:15*");
            //var a = scan.Where(x => x.Value.Id == 1574).FirstOrDefault();
            //var v = scan.Where(x => x.Value.Id == 1608).FirstOrDefault();

            //var scan1 = redisContext.Cache.ScanHashed<BsItemDTO>("items:hash", "item:*");
            //var aaa = scan1.Where(x => x.Value.Id == 847684).FirstOrDefault();            
        }

        [Fact(DisplayName = "GetObject_Test_OK", Skip="true")]
        [Trait(TraitName, TraitValue)]
        public void GetObject_Test_OK()
        {
            var location = redisContext.Cache.GetObjectA<BsLocationDTO>(1655);
            location.Should().NotBeNull();
        }

        [Fact]
        public void GetByTag()
        {
            var location = redisContext.Cache.GetKeysByTag(new[] { "101", "aaaa" }).ToArray();

            var loc1 = redisContext.Cache.GetObjectsByTag<BsLocationDTO>("1655").ToList();
            var loc2 = redisContext.Cache.GetObjectsByTag<BsLocationDTO>("101").ToList();
            
        }
    }
}
