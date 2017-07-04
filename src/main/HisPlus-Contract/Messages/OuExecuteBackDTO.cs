using System;
using System.Runtime.Serialization;
using AppPlus.Infrastructure.Contract.Messages;

namespace HisPlus.Contract.Messages
{
    [Serializable]
    [DataContract]
    public class OuExecuteBackDTO : DtoBase<int>
    {
        public OuExecuteBackDTO()
        {
        }

        [DataMember]
        public int ExecuteId { get; set; }

        [DataMember]
        public int ExecuteDtlId { get; set; }

        [DataMember]
        public System.DateTime OperTime { get; set; }

        [DataMember]
        public int OperId { get; set; }

        [DataMember]
        public bool IsBack { get; set; }

        [DataMember]
        public int? KsBackBillId { get; set; }

        [DataMember]
        public System.DateTime? BackTime { get; set; }
    }
}
