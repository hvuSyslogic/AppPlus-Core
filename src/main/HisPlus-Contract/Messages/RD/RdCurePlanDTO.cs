using AppPlus.Infrastructure.Contract.Messages;

namespace HisPlus.Contract.Messages
{
    public class RdCurePlanDTO : DtoBase<int>
    {
        public RdCurePlanDTO()
        {
        }

        public int PatId { get; set; }
        public System.DateTime OperTime { get; set; }
        public int OperId { get; set; }
        public string Code { get; set; }
        public string F1 { get; set; }
        public string F2 { get; set; }
        public string F3 { get; set; }
        public string F4 { get; set; }
        public string Illness { get; set; }
        public string CureItem { get; set; }
        public string CurePlan { get; set; }
        public System.DateTime? BeginTime { get; set; }
        public System.DateTime? EndTime { get; set; }
        public int? DoctorId { get; set; }
    }
}
