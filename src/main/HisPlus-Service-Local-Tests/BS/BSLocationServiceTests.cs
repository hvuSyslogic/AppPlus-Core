using AppPlus.Client;
using HisPlus.Contract.Services;
using HisPlus.Service.Local.Tests.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace HisPlus.Service.Local.Tests.BS
{
    public class BSLocationServiceTests : TestBase, IClassFixture<CommonServiceTestsFixture>
    {
        [Fact]
        public void TestMethod()
        {
            var result = CallService((IBsLocationService x) => x.RetrieveAll());
        }
    }
}
