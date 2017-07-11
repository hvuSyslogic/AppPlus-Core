using HisPlus.Client;
using HisPlus.Infrastructure.Contract.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace HisPlus.UnitTests.Common
{
    public class UnitTestBase
    {
        internal protected static void CallService<T>(Expression<Action<T>> expression)
           where T : HisPlus.Infrastructure.Contract.Services.IServiceRoot
        {
            ServiceHandler.CallService(expression);
        }

        internal protected static TResult CallService<T, TResult>(Expression<Func<T, TResult>> expression)
            where T : IServiceRoot
        {
            return ServiceHandler.CallService(expression);
        }
    }
}
