using HisPlus.Core.Redis;
using HisPlus.Infrastructure.Contract.Messages;
using HisPlus.Infrastructure.Contract.Services;
using HisPlus.Contract.Messages;
using HisPlus.Contract.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using HisPlus.UnitTests.Common;
using FluentAssertions;

namespace HisPlus.Redis.UnitTests
{
    public class RedisCacheUnitTests : TestBase
    {
        const string TraitName = "RedisCacheUnitTests";
        const string TraitValue = "RedisCache";

        [Fact(DisplayName="001_Cache")]
        [Trait(TraitName, TraitValue)]
        public void Cache_TestMethod()
        {
            string keyName = "BsLocation";

            CacheProvider repo = new CacheProvider(0);
            //if (repo.KeyExists(keyName))
            //{
            //    repo.KeyDelete(keyName);
            //}

            var result = CallService((IBsLocationService x) => x.RetrieveAll());
            result.Should().NotBeNullOrEmpty();

            repo.StringSet(keyName, result);
            repo.KeyExists(keyName).Should().BeTrue();

            var redisCacheResult = repo.StringGet<List<BsLocationDTO>>(keyName);
            redisCacheResult.Should().NotBeNullOrEmpty();

            result.Count().Should().Be(redisCacheResult.Count());

            //redis.StringSet("BsLocation", result);
        }

        //[Fact(DisplayName = "002_Redis_Cache_Large_Data")]
        //[Trait(TraitName, TraitValue)]
        public void Redis_LargeData_TestMethod()
        {
            string keyName = "BsItemUsage";

            CacheProvider repo = new CacheProvider(0);
            if (repo.KeyExists(keyName))
            {
                repo.KeyDelete(keyName);
            }

            var result = RetrieveByPage<IBsItemUsageService, BsItemUsageDTO, int>();            

            //repo.StringSet(keyName, result);

            repo.KeyExists(keyName).Should().BeTrue();
            var redisCacheResult = repo.StringGet<List<BsItemUsageDTO>>(keyName);
            redisCacheResult.Should().NotBeNullOrEmpty();
            
            result.Count().Should().Be(redisCacheResult.Count());
            //redis.StringSet("BsLocation", result);
        }

        private List<TDTO> RetrieveByPage<TService, TDTO, TKey>(int pageSize = 100000)
            where TService : IGenericService<TDTO, TKey>
            where TDTO : DtoBase<TKey>, new()
            where TKey : struct
        {
            string keyName = "BsItemUsage";
            CacheProvider repo = new CacheProvider(0);

            var pages = new List<TDTO>();
            int nextPageNumber = 1;
            int pageCount = 0;
            do
            {
                var page = CallService((TService x) => x.RetrievePagedData(nextPageNumber, pageSize, out pageCount));
                repo.StringSet(keyName, page);
                pages.AddRange(page);
            } while (nextPageNumber++ < pageCount);

            return pages;
        }     
    }
}
