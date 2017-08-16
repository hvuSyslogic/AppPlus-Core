using HisPlus.Contract.Messages;
using HisPlus.Contract.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentAssertions;
using Xunit;
using HisPlus.UnitTesting.Common;
using HisPlus.Infrastructure.Extensions;
using HisPlus.Redis;

namespace HisPlus.UnitTesting.Redis
{
    public partial class CacheFrameworkUnitTests : TestBase
    {
        [Fact(DisplayName = "FetchHashed_Test_OK")]
        [Trait(TraitName, TraitValue)]
        public void FetchHashed_Test_OK()
        {
            var locationId = 908;
            Func<BsLocationDTO> func = () => CallService((IBsLocationService x) => x.GetById(locationId));
            var location = redisContext.Cache.FetchHashed<BsLocationDTO>(locationId, func);
            location.Should().NotBeNull();
            location.Id.Should().Equals(locationId);

            var itemId = 334247;
            var item = redisContext.Cache.FetchHashed<BsItemDTO>(itemId, () => CallService((IBsItemService x) => x.GetById(itemId)));
            item.Should().NotBeNull();
            item.Id.Should().Equals(itemId);
        }

        [Fact(DisplayName = "TryGetHashed_Test_OK")]
        [Trait(TraitName, TraitValue)]
        public void TryGetHashed_Test_OK()
        {
            BsLocationDTO value;
            int id = 830;
            bool result = redisContext.Cache.TryGetHashed<BsLocationDTO>(id, out value);
            result.Should().BeTrue();
            value.Should().NotBeNull();
        }

        [Fact(DisplayName = "FetchObject_Test_OK")]
        [Trait(TraitName, TraitValue)]
        public void FetchObject_Test_OK()
        {
            int id = 830;
            var location = redisContext.Cache.FetchObject<BsLocationDTO>(id, () => CallService((IBsLocationService x) => x.GetById(id)));
            location.Should().NotBeNull();

            id = 828;
            location = redisContext.Cache.FetchObject<BsLocationDTO>(id, () => CallService((IBsLocationService x) => x.GetById(id)));
            location.Should().NotBeNull();
        }

        //[Fact]
        //public void aa()
        //{
        //    Func<string> func = () => SayHello("dragon");
        //}

        //public string SayHello(string name)
        //{
        //    return string.Format("Hello, {0}!", name);
        //}
    }
}
