using AppPlus.Infrastructure.Contract.Messages;

namespace HisPlus.Contract.Messages
{
    public class CsCostSubjDTO : DtoBase<int>
    {
        public CsCostSubjDTO()
        {
        }

        public string Code { get; set; }
        public string Name { get; set; }
        public string SuppItemCode { get; set; }
        public short? LsTreatMed { get; set; }
        public bool? IsLastLevel { get; set; }
        public int? CostSubjGrade { get; set; }
        public string PyCode { get; set; }
        public bool? IsActive { get; set; }
        public string F1 { get; set; }
        public string F2 { get; set; }
        public string F3 { get; set; }
        public string F4 { get; set; }
        public bool? IsFix { get; set; }
        public short? LsType { get; set; }
        public int? ClassId { get; set; }
        public string WbCode { get; set; }
        public short? OrderBy { get; set; }
        public bool? IsDerect { get; set; }
        public short? LsAppPara { get; set; }
        public string ToLocIds { get; set; }
    }
}
