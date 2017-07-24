using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using HisPlus.UnitTests.Common;
using FluentAssertions;
using HisPlus.Infrastructure.Cache;
using HisPlus.Infrastructure.Dependency;
using HisPlus.Infrastructure.Contract.Messages;
using HisPlus.Infrastructure.Contract.Services;
using HisPlus.Contract.Messages;
using HisPlus.Contract.Services;

namespace HisPlus.Redis.UnitTests
{
    public class RedisCacheUnitTests : TestBase
    {
        private const string TraitName = "RedisCacheUnitTests";
        private const string TraitValue = "RedisCache";
    
        [Fact(DisplayName = "001_Db0CacheProvider_StringSet_OK")]
        [Trait(TraitName, TraitValue)]
        public void Db0CacheProvider_StringSet_OK()
        {
            HisPlus.Infrastructure.Cache.ICacheProvider cacheProvider = IoCManager.Container.Resolve<Db0CacheProvider>();                

            var key = "Db0Cache";
            var value = "Db0CacheProvider_StringSet_OK";

            bool result = cacheProvider.StringSet(key, value);
            
            result.Should().BeTrue();
            cacheProvider.StringGet(key).Should().Be(value);
        }

        [Fact(DisplayName = "002_Db1CacheProvider_StringSet_OK")]
        [Trait(TraitName, TraitValue)]
        public void Db1CacheProvider_StringSet_OK()
        {
            ICacheProvider cacheProvider = IoCManager.Container.Resolve<Db1CacheProvider>();

            var key = "Db1Cache";
            var value = "Db1CacheProvider_StringSet_OK";

            bool result = cacheProvider.StringSet(key, value);

            result.Should().BeTrue();
            cacheProvider.StringGet(key).Should().Be(value);
        }

        [Fact(DisplayName = "003_Db2CacheProvider_StringSet_OK")]
        [Trait(TraitName, TraitValue)]
        public void Db2CacheProvider_StringSet_OK()
        {
            ICacheProvider cacheProvider = IoCManager.Container.Resolve<Db2CacheProvider>();

            var key = "Db2Cache";
            var value = "Db2CacheProvider_StringSet_OK";

            bool result = cacheProvider.StringSet(key, value);

            result.Should().BeTrue();
            cacheProvider.StringGet(key).Should().Be(value);
        }

        [Fact(DisplayName = "003_Db2CacheProvider_StringSet_Object_OK")]
        [Trait(TraitName, TraitValue)]
        public void Db2CacheProvider_StringSet_Object_OK()
        {
            var locations = CallService((IBsLocationService x) => x.RetrieveAll());

            ICacheProvider cacheProvider = IoCManager.Container.Resolve<Db2CacheProvider>();

            var key = "BSLOCATION";

            bool result = cacheProvider.StringSet(key, locations);
            
            result.Should().BeTrue();
            cacheProvider.StringGet<List<BsLocationDTO>>(key).Select(x => x.Code).Should().Equal(locations.Select(x => x.Code));
        }
    }
}
