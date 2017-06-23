using AppPlus.Infrastructure.Contract.Messages;

namespace HisPlus.Contract.Messages
{
    public class OuExecuteDtlADTO : DtoBase<System.DateTime>
    {
        public OuExecuteDtlADTO()
        {
        }

        public int? RecipeDtlId { get; set; }
        public string F1 { get; set; }
        public string F2 { get; set; }
        public string F3 { get; set; }
        public string F4 { get; set; }
        public decimal? Totality { get; set; }
        public int? UnitDiagId { get; set; }
        public System.DateTime? IssueTime { get; set; }
        public System.DateTime? BackTime { get; set; }
    }
}
