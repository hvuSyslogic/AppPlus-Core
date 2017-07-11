using AppPlus.Core.Redis;
using AppPlus.Infrastructure.Contract.Messages;
using AppPlus.Infrastructure.Contract.Services;
using HisPlus.Contract.Messages;
using HisPlus.Contract.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace HisPlus.Service.Local.Tests.Sample
{
    public class RedisTests : TestBase
    {
        [Fact]
        public void TestMethod()
        {
            string keyName = "BsLocation";

            CacheProvider repo = new CacheProvider(0);
            //if (repo.KeyExists(keyName))
            //{
            //    repo.KeyDelete(keyName);
            //}

            var result = CallService((IBsLocationService x) => x.RetrieveAll());
            Assert.NotNull(result);
            Assert.NotEmpty(result);

            repo.StringSet(keyName, result);

            Assert.True(repo.KeyExists(keyName));
            var redisCacheResult = repo.StringGet<List<BsLocationDTO>>(keyName);
            Assert.NotNull(redisCacheResult);
            Assert.NotEmpty(redisCacheResult);

            Assert.Equal(result.Count(), redisCacheResult.Count());
            
            //redis.StringSet("BsLocation", result);
        }

        [Fact]
        public void Redis_LargeData_TestMethod()
        {
            string keyName = "BsItemUsage";

            CacheProvider repo = new CacheProvider(0);
            if (repo.KeyExists(keyName))
            {
                repo.KeyDelete(keyName);
            }

            var result = RetrieveByPage<IBsItemUsageService, BsItemUsageDTO, int>();
            //Assert.NotNull(result);
            //Assert.NotEmpty(result);

            //repo.StringSet(keyName, result);

            Assert.True(repo.KeyExists(keyName));
            var redisCacheResult = repo.StringGet<List<BsItemUsageDTO>>(keyName);
            Assert.NotNull(redisCacheResult);
            Assert.NotEmpty(redisCacheResult);

            Assert.Equal(result.Count(), redisCacheResult.Count());

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
            int totalPages = 0;
            do
            {
                var page = CallService((TService x) => x.Filter(out totalPages, nextPageNumber, pageSize));
                repo.StringSet(keyName, page);
                pages.AddRange(page);
            } while (nextPageNumber++ < totalPages);

            return pages;
        }

        [Fact]
        public void PubSub()
        {
            Sub();        
        }

        public void Sub()
        {
            CacheProvider _redis = new CacheProvider(1);
            var channelKey = "Channel1";
            _redis.Subscribe(channelKey, (channel, message) =>
            {
                Console.WriteLine("接受到发布的内容为：" + message);
            });
            Console.WriteLine("您订阅的通道为：<< " + channelKey + " >> ! 请耐心等待消息的到来！！");
        }
    }
}
