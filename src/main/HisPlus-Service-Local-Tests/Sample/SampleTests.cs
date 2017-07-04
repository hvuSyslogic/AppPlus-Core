using AppPlus.Infrastructure.Contract.Services;
using HisPlus.Contract.Services;
using HisPlus.Service.Local.Tests.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace HisPlus.Service.Local.Tests.Sample
{
    public partial class SampleTests : TestBase//, IClassFixture<GblRoleServiceTestsFixture>
    {
        const string TraitName = "SampleTests";

        [Fact(DisplayName = "001_GetCurrentDataTime_OK")]
        [Trait(TraitName, "GetCurrentDateTime")]
        public void GetCurrentDateTime_OK()
        {
            var result = CallService((ISampleService x) => x.GetCurrentDateTime());
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
