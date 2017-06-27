using AppPlus.Infrastructure.Contract.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace HisPlus.Contract.Services
{
    [ServiceContract]
    public interface ISampleService : IServiceRoot
    {
        void test();
    }
}
