using AppPlus.Infrastructure.Contract.Messages;

namespace HisPlus.Contract.Messages
{
    public class CsInWorkLogDTO : DtoBase<int>
    {
        public CsInWorkLogDTO()
        {
        }

        public string YearMonth { get; set; }
        public int LocId { get; set; }
        public int? OriginalNum { get; set; }
        public int? AdmittedOutps { get; set; }
        public int? FromOtherDept { get; set; }
        public int? TotalInHospitalDays { get; set; }
        public int? TotalInDeptDays { get; set; }
        public int? TransDeptNum { get; set; }
        public int? TotalBedUsedDays { get; set; }
        public int? OperId { get; set; }
        public System.DateTime? InputTime { get; set; }
        public decimal? BedUsedRates { get; set; }
        public string F1 { get; set; }
        public string F2 { get; set; }
        public string F3 { get; set; }
        public string F4 { get; set; }
    }
}
