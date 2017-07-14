using HisPlus.Infrastructure.Contract.Messages;
using HisPlus.UnitTests.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HisPlus.Service.UnitTests.Common
{
    public abstract class TestsFixtureBase<TDTO> : UnitTestBase<TDTO>, IDisposable
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
