using AppPlus.Infrastructure.Contract.Messages;

namespace HisPlus.Contract.Messages
{
    public class InChinRicipeDTO : DtoBase<int>
    {
        public InChinRicipeDTO()
        {
        }

        public string RecipeNo { get; set; }
        public int HospId { get; set; }
        public int LocationId { get; set; }
        public int DoctorId { get; set; }
        public short DrugNum { get; set; }
        public short DecoctNum { get; set; }
        public bool IsConfirm { get; set; }
        public short LsCookSelf { get; set; }
        public int? ConfirmOperId { get; set; }
        public System.DateTime? ConfirmOperTime { get; set; }
        public bool IsBack { get; set; }
        public bool IsPrint { get; set; }
        public string Memo { get; set; }
        public int OperId { get; set; }
        public System.DateTime OperTime { get; set; }
        public string F1 { get; set; }
        public string F2 { get; set; }
        public string F3 { get; set; }
        public string F4 { get; set; }
        public int? FrequencyId { get; set; }
        public int? UsageId { get; set; }
        public bool? IsPriority { get; set; }
        public bool? IsAuth { get; set; }
        public System.DateTime? BackTime { get; set; }
        public short? CookMinute { get; set; }
        public short? LsFire { get; set; }
        public int? AdviceLocationId { get; set; }
    }
}
