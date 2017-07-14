using HisPlus.Client;
using HisPlus.Infrastructure.Contract.Messages;
using HisPlus.Infrastructure.Contract.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace HisPlus.UnitTests.Common
{
    public class UnitTestBase<TDTO> : TestBase where TDTO : DtoRoot
    {
        protected static IEnumerable<TDTO> MockCollections = new List<TDTO>();
    }

    public class TestBase
    {
        protected void CallService<T>(Expression<Action<T>> expression)
           where T : IServiceRoot
        {
            ServiceHandler.CallService(expression);
        }

        protected TResult CallService<T, TResult>(Expression<Func<T, TResult>> expression)
            where T : IServiceRoot
        {
            return ServiceHandler.CallService(expression);
        }
    }
}
