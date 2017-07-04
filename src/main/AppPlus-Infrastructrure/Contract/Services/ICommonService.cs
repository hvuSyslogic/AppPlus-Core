using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using AppPlus.Infrastructure.Contract.Messages;

namespace AppPlus.Infrastructure.Contract.Services
{    
    [ServiceContract]
    public interface ICommonService : IServiceRoot
    {
        //[OperationContract, FaultContract(typeof(ServiceFault))]
        //byte[] Process(string serviceName, string methodName, params byte[] arguments);

        #region GetDateTime
        [OperationContract(Name = "GetDateTime")]
        DateTime GetCurrentDateTime();
        #endregion
    }
}
