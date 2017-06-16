using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace AppPlus.Infrastructure.Contracts.Services
{
    [ServiceContract]
    public interface IServiceRoot : IDisposable
    {
    }
}
