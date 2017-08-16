using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace HisPlus.Infrastructure.Contract.Services
{
    [ServiceContract]
    public interface IServiceRoot
    {
        [OperationContract]
        DateTime GetCurrentDateTime();
    }
}
