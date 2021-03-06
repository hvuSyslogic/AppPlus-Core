using System;
using System.Runtime.Serialization;
using HisPlus.Infrastructure.Contract.Messages;

namespace HisPlus.Contract.Messages
{
    [Serializable]
    [DataContract]
    public class InRmKsDtlDTO : DtoBase<int>
    {
        public InRmKsDtlDTO()
        {
        }

        [DataMember]
        public int? DetailId { get; set; }

        [DataMember]
        public int BillId { get; set; }
    }
}
