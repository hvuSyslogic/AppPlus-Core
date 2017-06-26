using System;
using System.Runtime.Serialization;
using AppPlus.Infrastructure.Contract.Messages;

namespace HisPlus.Contract.Messages
{
    [Serializable]
    [DataContract]
    public class CkMachineResultADTO : DtoBase<System.DateTime>
    {
        public CkMachineResultADTO()
        {
        }
    }
}
