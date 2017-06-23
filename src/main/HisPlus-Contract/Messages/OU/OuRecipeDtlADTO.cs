using AppPlus.Infrastructure.Contract.Messages;

namespace HisPlus.Contract.Messages
{
    public class OuRecipeDtlADTO : DtoBase<System.DateTime>
    {
        public OuRecipeDtlADTO()
        {
        }

        public int? UnitTakeId { get; set; }
        public int? FrequencyId { get; set; }
        public int? UsageId { get; set; }
        public short? Days { get; set; }
        public int? XdRpId { get; set; }
        public System.DateTime? CancelTime { get; set; }
        public int? CancelOperId { get; set; }
        public System.DateTime? PrintTime { get; set; }
        public int? PrintOperId { get; set; }
        public string PrepareTime { get; set; }
        public int? PrepareOperId { get; set; }
        public System.DateTime? IssueTime { get; set; }
        public int? IssueOperId { get; set; }
        public string F1 { get; set; }
        public string F2 { get; set; }
        public string F3 { get; set; }
        public string F4 { get; set; }
        public bool? IsDoctorInput { get; set; }
        public int? RecNum { get; set; }
        public System.DateTime? RecipeTime { get; set; }
        public int? LocationId { get; set; }
        public int? DoctorId { get; set; }
        public string F5 { get; set; }
        public string F6 { get; set; }
        public string F7 { get; set; }
        public string F8 { get; set; }
        public int? AllPageNo { get; set; }
        public int? PageNo { get; set; }
        public bool? IsBp { get; set; }
        public string BpReason { get; set; }
    }
}
