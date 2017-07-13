using HisPlus.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace HisPlus.Service.UnitTests
{
    public class DependencyContextUnitTests
    {
        [Fact]
        public void TestRegister()
        {
            var container = DependencyContext.Current;
        }
    }
}
