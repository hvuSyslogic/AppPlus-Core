using AppPlus.Client;
using AppPlus.Infrastructure.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
          
namespace HisPlus.Service.Remote.Tests.Common
{
    public class TestBase 
    {
        private const string Host = "localhost";
        private const int Port = 14293;

        static TestBase()
        {
            AppConfigurator.WithServiceMode(Host, Port);
        }

        internal protected static void CallService<T>(Expression<Action<T>> expression)
            where T : AppPlus.Infrastructure.Contract.Services.IServiceRoot
        {
            ServiceHandler.CallService(expression);
        }

        internal protected static TResult CallService<T, TResult>(Expression<Func<T, TResult>> expression)
            where T : AppPlus.Infrastructure.Contract.Services.IServiceRoot
        {
            return ServiceHandler.CallService(expression);
        }
    }
}
