using System;
using System.Runtime.Serialization;
using HisPlus.Infrastructure.Contract.Messages;

namespace HisPlus.Contract.Messages
{
    [Serializable]
    [DataContract]
    public class CkInFeeDTO : DtoBase<int>
    {
        public CkInFeeDTO()
        {
        }

        [DataMember]
        public int LabId { get; set; }

        [DataMember]
        public int? DetailId { get; set; }
    }
}
