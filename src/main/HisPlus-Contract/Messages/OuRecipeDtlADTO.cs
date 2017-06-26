using System;
using System.Runtime.Serialization;
using AppPlus.Infrastructure.Contract.Messages;

namespace HisPlus.Contract.Messages
{
    [Serializable]
    [DataContract]
    public class OuRecipeDtlADTO : DtoBase<System.DateTime>
    {
        public OuRecipeDtlADTO()
        {
        }

        [DataMember]
        public int? UnitTakeId { get; set; }

        [DataMember]
        public int? FrequencyId { get; set; }

        [DataMember]
        public int? UsageId { get; set; }

        [DataMember]
        public short? Days { get; set; }

        [DataMember]
        public int? XdRpId { get; set; }

        [DataMember]
        public System.DateTime? CancelTime { get; set; }

        [DataMember]
        public int? CancelOperId { get; set; }

        [DataMember]
        public System.DateTime? PrintTime { get; set; }

        [DataMember]
        public int? PrintOperId { get; set; }

        [DataMember]
        public string PrepareTime { get; set; }

        [DataMember]
        public int? PrepareOperId { get; set; }

        [DataMember]
        public System.DateTime? IssueTime { get; set; }

        [DataMember]
        public int? IssueOperId { get; set; }

        [DataMember]
        public string F1 { get; set; }

        [DataMember]
        public string F2 { get; set; }

        [DataMember]
        public string F3 { get; set; }

        [DataMember]
        public string F4 { get; set; }

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
        public string F5 { get; set; }

        [DataMember]
        public string F6 { get; set; }

        [DataMember]
        public string F7 { get; set; }

        [DataMember]
        public string F8 { get; set; }

        [DataMember]
        public int? AllPageNo { get; set; }

        [DataMember]
        public int? PageNo { get; set; }

        [DataMember]
        public bool? IsBp { get; set; }

        [DataMember]
        public string BpReason { get; set; }
    }
}
