using System;
using System.Runtime.Serialization;
using AppPlus.Infrastructure.Contract.Messages;

namespace HisPlus.Contract.Messages
{
    [Serializable]
    [DataContract]
    public class PsDrugActionDTO : DtoBase<int>
    {
        public PsDrugActionDTO()
        {
        }

        [DataMember]
        public string ApplyNo { get; set; }

        [DataMember]
        public System.DateTime OperTime { get; set; }

        [DataMember]
        public int OperId { get; set; }

        [DataMember]
        public int? LocationId { get; set; }

        [DataMember]
        public int? DoctorId { get; set; }

        [DataMember]
        public int PatId { get; set; }

        [DataMember]
        public int? MzRegId { get; set; }

        [DataMember]
        public int? HospId { get; set; }

        [DataMember]
        public bool IsCancel { get; set; }

        [DataMember]
        public System.DateTime? CancelTime { get; set; }

        [DataMember]
        public int? CancelOperId { get; set; }

        [DataMember]
        public int? ItemId { get; set; }

        [DataMember]
        public System.DateTime? ReactTime { get; set; }

        [DataMember]
        public short? LsTransType { get; set; }

        [DataMember]
        public string ClincHandle { get; set; }

        [DataMember]
        public string Memo { get; set; }

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
