using System.Data.Entity.ModelConfiguration;
using AppPlus.Infrastructure.Contract.Messages;

namespace HisPlus.Domain
{
    public class NrPlan : EntityBase<int>
    {
        public NrPlan()
        {    
        }

        public int? HospId { get; set; }
        public int? LocationId { get; set; }
        public int? OperId { get; set; }
        public System.DateTime? OperTime { get; set; }
        public int? IcdId { get; set; }
        public string IllDesc { get; set; }
        public string Target { get; set; }
        public string Measure { get; set; }
        public string BasisOf { get; set; }
        public string Evaluate { get; set; }
        public int? EvalOperId { get; set; }
        public System.DateTime? EvalTime { get; set; }
        public string F1 { get; set; }
        public string F2 { get; set; }
        public string F3 { get; set; }
        public string F4 { get; set; }
    }
}
