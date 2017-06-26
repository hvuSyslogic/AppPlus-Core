using System;
using System.Runtime.Serialization;
using AppPlus.Infrastructure.Contract.Messages;

namespace HisPlus.Contract.Messages
{
    [Serializable]
    [DataContract]
    public class OpsPostTreatDTO : DtoBase<string>
    {
        public OpsPostTreatDTO()
        {
        }
    }
}
