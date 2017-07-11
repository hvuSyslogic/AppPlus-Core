using System;
using System.Runtime.Serialization;
using HisPlus.Infrastructure.Contract.Messages;

namespace HisPlus.Contract.Messages
{
    [Serializable]
    [DataContract]
    public class OuRecipeDtlDTO : DtoBase<int>
    {
        public OuRecipeDtlDTO()
        {
        }

        [DataMember]
        public int RecipeId { get; set; }

        [DataMember]
        public int ListNum { get; set; }

        [DataMember]
        public int ItemId { get; set; }

        [DataMember]
        public short GroupNum { get; set; }

        [DataMember]
        public decimal Dosage { get; set; }

        [DataMember]
        public int? UnitTakeId { get; set; }

        [DataMember]
        public int? FrequencyId { get; set; }

        [DataMember]
        public int? UsageId { get; set; }

        [DataMember]
        public short? Days { get; set; }

        [DataMember]
        public decimal Totality { get; set; }

        [DataMember]
        public int UnitDiagId { get; set; }

        [DataMember]
        public bool IsAttach { get; set; }

        [DataMember]
        public bool IsOtherFee { get; set; }

        [DataMember]
        public int? XdRpId { get; set; }

        [DataMember]
        public string Memo { get; set; }

        [DataMember]
        public bool IsCharged { get; set; }

        [DataMember]
        public bool IsCancel { get; set; }

        [DataMember]
        public System.DateTime? CancelTime { get; set; }

        [DataMember]
        public int? CancelOperId { get; set; }

        [DataMember]
        public bool IsPrint { get; set; }

        [DataMember]
        public System.DateTime? PrintTime { get; set; }

        [DataMember]
        public int? PrintOperId { get; set; }

        [DataMember]
        public bool IsPrepared { get; set; }

        [DataMember]
        public string PrepareTime { get; set; }

        [DataMember]
        public int? PrepareOperId { get; set; }

        [DataMember]
        public bool IsIssue { get; set; }

        [DataMember]
        public System.DateTime? IssueTime { get; set; }

        [DataMember]
        public int? IssueOperId { get; set; }

        [DataMember]
        public bool IsToBack { get; set; }

        [DataMember]
        public bool IsBack { get; set; }

        [DataMember]
        public bool? IsDoctorInput { get; set; }

        [DataMember]
        public int? RecNum { get; set; }

        [DataMember]
        public System.DateTime? RecipeTime { get; set; }

        [DataMember]
        public int? LocationId { get; set; }

        [DataMember]
        public int? DoctorId { get; set; }

        [DataMember]
        public int? AllPageNo { get; set; }

        [DataMember]
        public int? PageNo { get; set; }

        [DataMember]
        public int? CureDtlId { get; set; }

        [DataMember]
        public bool? IsBp { get; set; }

        [DataMember]
        public string BpReason { get; set; }

        [DataMember]
        public string YbType { get; set; }

        [DataMember]
        public string InvoNo { get; set; }

        [DataMember]
        public bool? IsAutoCharged { get; set; }
    }
}
