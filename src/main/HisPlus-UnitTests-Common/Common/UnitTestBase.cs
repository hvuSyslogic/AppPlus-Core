using HisPlus.Infrastructure.Contract.Messages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HisPlus.UnitTesting.Common
{
    public class UnitTestBase<TDTO> : TestBase where TDTO : DtoRoot
    {
        public static IEnumerable<TDTO> DataSource
        {
            get;
            set;
        }
    }
}
