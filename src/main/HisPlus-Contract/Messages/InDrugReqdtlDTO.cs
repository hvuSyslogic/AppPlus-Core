using System;
using System.Runtime.Serialization;
using HisPlus.Infrastructure.Contract.Messages;

namespace HisPlus.Contract.Messages
{
    [Serializable]
    [DataContract]
    public class InDrugReqdtlDTO : DtoBase<int>
    {
        public InDrugReqdtlDTO()
        {
        }

        [DataMember]
        public int RequestId { get; set; }

        [DataMember]
        public int ListNum { get; set; }

        [DataMember]
        public int HospId { get; set; }

        [DataMember]
        public System.DateTime ForDate { get; set; }

        [DataMember]
        public int ItemId { get; set; }

        [DataMember]
        public int AdviceId { get; set; }

        [DataMember]
        public short GroupNum { get; set; }

        [DataMember]
        public short LsMarkType { get; set; }

        [DataMember]
        public decimal? Dosage { get; set; }

        [DataMember]
        public int UnitReq { get; set; }

        [DataMember]
        public int? UnitTake { get; set; }

        [DataMember]
        public decimal Totality { get; set; }

        [DataMember]
        public int? FrequencyId { get; set; }

        [DataMember]
        public int? UsageId { get; set; }

        [DataMember]
        public bool IsPrint { get; set; }

        [DataMember]
        public bool IsIssued { get; set; }

        [DataMember]
        public bool IsConfirm { get; set; }

        [DataMember]
        public int? ConfirmOperId { get; set; }

        [DataMember]
        public System.DateTime? ConfirmOperTime { get; set; }

        [DataMember]
        public int? DetailId { get; set; }

        [DataMember]
        public int? ExecuteId { get; set; }

        [DataMember]
        public string RegDate { get; set; }

        [DataMember]
        public int? LsSecMarkType { get; set; }

        [DataMember]
        public string BedName { get; set; }

        [DataMember]
        public bool? Refusal { get; set; }

        [DataMember]
        public bool? IsArrearage { get; set; }

        [DataMember]
        public int? DoctorId { get; set; }

        [DataMember]
        public int? OperId { get; set; }

        [DataMember]
        public decimal? PriceIn { get; set; }

        [DataMember]
        public bool? LsArrearage { get; set; }

        [DataMember]
        public string DoctorName { get; set; }

        [DataMember]
        public bool? IsOutDrug { get; set; }

        [DataMember]
        public string UsageMemo { get; set; }

        [DataMember]
        public System.DateTime? UseTime { get; set; }
    }
}
