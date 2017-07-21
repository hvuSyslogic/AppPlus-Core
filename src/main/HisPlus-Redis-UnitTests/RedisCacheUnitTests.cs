
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

        [Fact(DisplayName="001_Cache")]
        [Trait(TraitName, TraitValue)]
        public void Cache_TestMethod()
        {
            string keyName = "redBsLocation";

            ICacheProvider cacheProvider = IoCManager.Container.Resolve<ICacheProvider>(new { db = 1 });
            var key = "aaa";
            var value = "AAAA";

            bool result = cacheProvider.StringSet(key, value);
            if (result)
            {
                cacheProvider.StringGet(key).Should().Be(value);
            }

            //var locations = cacheProvider.StringGet(keyName);

            //var result = CallService((IBsLocationService x) => x.RetrieveAll());
            //result.Should().NotBeNullOrEmpty();

            //baseDataCache.CurrentDB.ListLeftPush(keyName, result.ToArray(), StackExchange.Redis.CommandFlags.FireAndForget);

            //repo.KeyExists(keyName).Should().BeTrue();

            //var redisCacheResult = repo.StringGet<List<BsLocationDTO>>(keyName);
            //redisCacheResult.Should().NotBeNullOrEmpty();

            //result.Count().Should().Be(redisCacheResult.Count());

            //redis.StringSet("BsLocation", result);
        }

        //[Fact(DisplayName = "002_Redis_Cache_Large_Data")]
        //[Trait(TraitName, TraitValue)]
        //public void Redis_LargeData_TestMethod()
        //{
        //    string keyName = "BsItemUsage";

        //    ICacheProvider repo = DependencyContext.Container.Resolve<ICacheProvider>(); ;
        //    if (repo.KeyExists(keyName))
        //    {
        //        repo.KeyDelete(keyName);
        //    }

        //    var result = RetrieveByPage<IBsItemUsageService, BsItemUsageDTO, int>();            

        //    //repo.StringSet(keyName, result);

        //    repo.KeyExists(keyName).Should().BeTrue();
        //    var redisCacheResult = repo.StringGet<List<BsItemUsageDTO>>(keyName);
        //    redisCacheResult.Should().NotBeNullOrEmpty();
            
        //    result.Count().Should().Be(redisCacheResult.Count());
        //    //redis.StringSet("BsLocation", result);
        //}

        //private List<TDTO> RetrieveByPage<TService, TDTO, TKey>(int pageSize = 100000)
        //    where TService : IGenericService<TDTO, TKey>
        //    where TDTO : DtoBase<TKey>, new()
        //    where TKey : struct
        //{
        //    string keyName = "BsItemUsage";
        //    CacheProvider repo = DependencyContext.Container.Resolve<ICacheProvider>();

        //    var pages = new List<TDTO>();
        //    int nextPageNumber = 1;
        //    int pageCount = 0;
        //    do
        //    {
        //        var page = CallService((TService x) => x.RetrievePagedData(nextPageNumber, pageSize, out pageCount));
        //        repo.StringSet(keyName, page);
        //        pages.AddRange(page);
        //    } while (nextPageNumber++ < pageCount);

        //    return pages;
        //}     
    }
}
