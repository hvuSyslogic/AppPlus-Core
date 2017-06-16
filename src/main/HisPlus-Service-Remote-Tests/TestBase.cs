using AppPlus.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace AppPlus.His.Services.Tests
{
    public class TestBase 
    {
        private const string ServiceHost = "localhost";
        private const int Port = 14293;

        static TestBase()
        {
            ProxyManager.ServiceHost = ServiceHost;
            ProxyManager.Port = Port;
        }

        internal protected static void CallService<T>(Expression<Action<T>> expression)
            where T : AppPlus.Infrastructure.Contracts.Services.IServiceRoot
        {
            ServiceHandler.CallService(expression);
        }

        internal protected static TResult CallService<T, TResult>(Expression<Func<T, TResult>> expression)
            where T : AppPlus.Infrastructure.Contracts.Services.IServiceRoot
        {
            return ServiceHandler.CallService(expression);
        }
    }
}
