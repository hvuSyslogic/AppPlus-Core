using System;
using System.Runtime.Serialization;
using AppPlus.Infrastructure.Contract.Messages;

namespace HisPlus.Contract.Messages
{
    [Serializable]
    [DataContract]
    public class InLocNoPayDTO : DtoBase<int>
    {
        public InLocNoPayDTO()
        {
        }

        [DataMember]
        public System.DateTime ReportDate { get; set; }

        [DataMember]
        public int LocationId { get; set; }

        [DataMember]
        public int ExecLocId { get; set; }

        [DataMember]
        public int FeeId { get; set; }

        [DataMember]
        public short LsInStatus { get; set; }

        [DataMember]
        public decimal Amount { get; set; }

        [DataMember]
        public System.DateTime Opertime { get; set; }
    }
}
