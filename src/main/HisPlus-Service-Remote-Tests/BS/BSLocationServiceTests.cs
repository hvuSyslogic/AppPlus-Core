using AppPlus.Client;
using HisPlus.Contract.Services;
using HisPlus.Service.Remote.Tests.Common;
using HisPlus.Service.Remote.Tests.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace HisPlus.His.Service.Remote.Tests.BS
{
    public class BSLocationServiceTests : TestBase, IClassFixture<CommonServiceTestsFixture>
    {
        [Fact]
        public void TestMethod()
        {
            var result = CallService((IBsLocationService x) => x.RetrieveAll());

            Assert.NotNull(result);
            Assert.NotEmpty(result);
        }
    }
}