using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using HisPlus.Infrastructure.Contract.Messages;

namespace HisPlus.Infrastructure.Contract.Services
{    
    [ServiceContract]
    public interface ICommonService : IServiceRoot
    {
        //[OperationContract, FaultContract(typeof(ServiceFault))]
        //byte[] Process(string serviceName, string methodName, params byte[] arguments);
    }
}
