using System;
using System.Runtime.Serialization;
using AppPlus.Infrastructure.Contract.Messages;

namespace HisPlus.Contract.Messages
{
    [Serializable]
    [DataContract]
    public class CsOuWorkLogDTO : DtoBase<int>
    {
        public CsOuWorkLogDTO()
        {
        }

        [DataMember]
        public string YearMonth { get; set; }

        [DataMember]
        public int LocId { get; set; }

        [DataMember]
        public int OutpNum { get; set; }

        [DataMember]
        public int OperatedNum { get; set; }

        [DataMember]
        public int? OperId { get; set; }

        [DataMember]
        public System.DateTime? InputTime { get; set; }

        [DataMember]
        public string F1 { get; set; }

        [DataMember]
        public string F2 { get; set; }

        [DataMember]
        public string F3 { get; set; }

        [DataMember]
        public string F4 { get; set; }
    }
}
