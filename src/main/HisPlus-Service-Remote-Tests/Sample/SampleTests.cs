using AppPlus.Infrastructure.Contract.Services;
using HisPlus.Contract.Services;
using HisPlus.Service.Remote.Tests.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace HisPlus.Service.Remote.Tests.Sample
{
    public partial class SampleTests : TestBase
    {
        const string TraitName = "SampleTests.Remote";
         
        [Fact(DisplayName = "001_GetCurrentDataTime_OK")]
        [Trait(TraitName, "GetCurrentDataTime")]
        public void GetCurrentDataTime_OK()
        {
            var result = CallService((ICommonService x) => x.GetCurrentDateTime());
            Assert.IsType<DateTime>(result);
            Assert.NotNull(result);
        }

        [Fact(DisplayName = "002_EntityFramework_L1_Cache_OK")]
        [Trait(TraitName, "EntityFramework_L1_Cache")]
        public void EntityFramework_L1_Cache_OK()
        {
            var result = CallService((ISampleService x) => x.L1CacheTest());
        }

        [Fact(DisplayName = "002_DbTransaction_OK")]
        [Trait(TraitName, "DbTransaction_OK")]
        public void DbTransaction_NOK()
        {
            var result = CallService((ISampleService x) => x.TransactionTest());
        }
    }
}
