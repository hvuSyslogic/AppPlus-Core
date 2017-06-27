using HisPlus.Contract.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace HisPlus.Service.Local.Tests.Sample
{
    public partial class SampleTests : TestBase
    {
        [Fact]
        public void Test()
        {
            CallService((ISampleService x) => x.test());
        }
    }
}
