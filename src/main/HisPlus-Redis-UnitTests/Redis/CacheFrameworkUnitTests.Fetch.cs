using HisPlus.Contract.Messages;
using HisPlus.Contract.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HisPlus.Infrastructure.Cache;
using FluentAssertions;
using Xunit;
using HisPlus.UnitTesting.Common;

namespace HisPlus.UnitTesting.Redis
{
    public partial class CacheFrameworkUnitTests : TestBase
    {
        [Fact(DisplayName = "FetchHashed_Test_OK")]
        [Trait(TraitName, TraitValue)]
        public void FetchHashed_Test_OK()
        {
            var locationId = 1573;
            var location = redisContext.Cache.FetchHashed<BsLocationDTO>(locationId, () => CallService((IBsLocationService x) => x.RetrieveById(locationId)));
            location.Should().NotBeNull();
            location.Id.Should().Equals(locationId);

            var itemId = 304822;
            var item = redisContext.Cache.FetchHashed<BsItemDTO>(itemId, () => CallService((IBsItemService x) => x.RetrieveById(itemId)));
            item.Should().NotBeNull();
            item.Id.Should().Equals(itemId);
        }

        [Fact(DisplayName = "TryGetHashed_Test_OK")]
        [Trait(TraitName, TraitValue)]
        public void TryGetHashed_Test_OK()
        {
            BsLocationDTO value;
            int id = 1572;
            bool result = redisContext.Cache.TryGetHashed<BsLocationDTO>(id, out value);
            result.Should().BeTrue();
            value.Should().NotBeNull();
        }

        [Fact(DisplayName = "FetchObject_Test_OK")]
        [Trait(TraitName, TraitValue)]
        public void FetchObject_Test_OK()
        {
            int id = 1572;
            var location = redisContext.Cache.FetchObject<BsLocationDTO>(id, () => CallService((IBsLocationService x) => x.RetrieveById(id)));
            location.Should().NotBeNull();

            id = 1573;
            location = redisContext.Cache.FetchObject<BsLocationDTO>(id, () => CallService((IBsLocationService x) => x.RetrieveById(id)));
            location.Should().NotBeNull();
        }
    }
}
