using System;
using System.Runtime.Serialization;
using AppPlus.Infrastructure.Contract.Messages;

namespace HisPlus.Contract.Messages
{
    [Serializable]
    [DataContract]
    public class ElTipsPatDTO : DtoBase<int>
    {
        public ElTipsPatDTO()
        {
        }

        [DataMember]
        public int? HospitalId { get; set; }

        [DataMember]
        public int? TipId { get; set; }

        [DataMember]
        public string Tips { get; set; }

        [DataMember]
        public int? PatFormId { get; set; }

        [DataMember]
        public System.DateTime OperTime { get; set; }

        [DataMember]
        public short? ActiveDays { get; set; }

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
