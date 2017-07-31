using HisPlus.Contract.Messages;
using HisPlus.Contract.Services;
using HisPlus.Infrastructure.Cache;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentAssertions;
using Xunit;
using HisPlus.Infrastructure.Extensions;

namespace HisPlus.UnitTesting.Redis
{
    public partial class CacheFrameworkUnitTests
    {
        [Fact(DisplayName = "GetHashed_Test_OK")]
        [Trait(TraitName, TraitValue)]
        public void GetHashed_Test_OK()
        {
            var location = redisContext.Cache.GetHashed<BsLocationDTO>(1573);
            location.Should().NotBeNull();

            //IDictionary<string, BsItemDTO> items = await redisContext.Cache.GetHashedAllAsync<BsItemDTO>("items:hash");

            //IDictionary<string, BsLocationDTO> result = await redisContext.Cache.GetHashedAllAsync<BsLocationDTO>("locations:hash");

            //var scan = redisContext.Cache.ScanHashed<BsLocationDTO>("locations:hash", "location:id:15*");
            //var a = scan.Where(x => x.Value.Id == 1574).FirstOrDefault();
            //var v = scan.Where(x => x.Value.Id == 1608).FirstOrDefault();

            //var scan1 = redisContext.Cache.ScanHashed<BsItemDTO>("items:hash", "item:*");
            //var aaa = scan1.Where(x => x.Value.Id == 847684).FirstOrDefault();            
        }

        [Fact(DisplayName = "GetObject_Test_OK")]
        [Trait(TraitName, TraitValue)]
        public void GetObject_Test_OK()
        {
            var location = redisContext.Cache.GetObject<BsLocationDTO>(1572);
            location.Should().NotBeNull();
        }
    }
}
