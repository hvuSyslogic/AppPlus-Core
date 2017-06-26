using System;
using System.Runtime.Serialization;
using AppPlus.Infrastructure.Contract.Messages;

namespace HisPlus.Contract.Messages
{
    [Serializable]
    [DataContract]
    public class TrSchedulerDTO : DtoBase<int>
    {
        public TrSchedulerDTO()
        {
        }

        [DataMember]
        public int UserId { get; set; }

        [DataMember]
        public int LineId { get; set; }

        [DataMember]
        public System.DateTime ScheTime { get; set; }

        [DataMember]
        public System.DateTime OperTime { get; set; }

        [DataMember]
        public int OperId { get; set; }

        [DataMember]
        public string F1 { get; set; }

        [DataMember]
        public string F2 { get; set; }

        [DataMember]
        public string F3 { get; set; }

        [DataMember]
        public string F4 { get; set; }

        [DataMember]
        public short? IconIndex { get; set; }
    }
}
