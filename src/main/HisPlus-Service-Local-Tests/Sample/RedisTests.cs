using AppPlus.Core.Redis;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace HisPlus.Service.Local.Tests.Sample
{
    public class RedisTests
    {
        [Fact]
        public void TestMethod()
        {
            RedisRepository repo = new RedisRepository(0);
            string stringValue = "aaaa";
            repo.StringSet("111", stringValue);

            var result = repo.StringGet("111");

            Assert.Equal(stringValue, result);
        }
    }
}
