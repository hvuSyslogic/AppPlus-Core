using AppPlus.Infrastructure.Contract.Messages;
using HisPlus.Service.Remote.Tests.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HisPlus.Service.Remote.Tests.Common
{
    public abstract class TestsFixtureBase<TDTO> : TestBase, IDisposable
        where TDTO: DtoRoot
    {
        public TestsFixtureBase()
        {
            MockData();
        }

        public abstract void Clean();

        public abstract void MockData();

        public void Dispose()
        {
            Clean();
        }
    }
}
