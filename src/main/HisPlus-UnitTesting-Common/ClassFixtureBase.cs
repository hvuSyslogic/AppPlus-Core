using HisPlus.Infrastructure.Contract.Messages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HisPlus.UnitTesting.Common
{
    public abstract class ClassFixtureBase<TDTO> : UnitTestBase<TDTO>, IDisposable
        where TDTO: DtoRoot
    {        
        public ClassFixtureBase()
        {            
        }

        public abstract void CleanDataSource();

        public abstract void BuildDataSource();

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);            
        }

        private void Dispose(bool disposing)
        {
            CleanDataSource();
        }
    }
}
