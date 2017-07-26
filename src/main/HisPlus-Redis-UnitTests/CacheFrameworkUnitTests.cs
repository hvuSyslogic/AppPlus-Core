using HisPlus.Contract.Messages;
using HisPlus.Contract.Services;
using HisPlus.Infrastructure.Cache;
using HisPlus.Infrastructure.Dependency;
using HisPlus.UnitTests.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace HisPlus.Redis.UnitTests
{
    public class CacheFrameworkUnitTests : TestBase
    {
        private static readonly IRedisContext redisContext = IoCManager.Container.Resolve<IRedisContext>();

        [Fact]
        public void SetHashed_TestMethod()
        {
            CallService((IBsLocationService x) => x.RetrieveAll()).ToList().ForEach(x => InsertLocation(redisContext, x));

            CallService((IBsItemService x) => x.RetrieveAll()).ToList().ForEach(x => InsertItem(redisContext, x));
            
        }

        [Fact]
        public void Fetch()
        {
            var locations = redisContext.Cache.GetHashed<BsLocationDTO>("locations:hash", "location:id:1573");

            IDictionary<string, BsLocationDTO> result = redisContext.Cache.GetHashedAll<BsLocationDTO>("locations:hash");
            //var scan = context.Cache.ScanHashed<BsLocationDTO>("locations:hash", "location:id:15*");
        }

        void InsertLocation(IRedisContext context, BsLocationDTO location)
        {
            var redisKey = "locations:hash";
            var fieldKey = "location:id:" + location.Id;
            context.Cache.SetHashed(redisKey, fieldKey, location);
        }

        void InsertItem(IRedisContext context, BsItemDTO item)
        {
            var redisKey = "items:hash";
            var fieldKey = "item:id:" + item.Id;
            context.Cache.SetHashed(redisKey, fieldKey, item);
        }
    }
}
