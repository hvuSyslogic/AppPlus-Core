using AppPlus.Infrastructure.Contract.Messages;
using System.Data.Entity.ModelConfiguration;

namespace HisPlus.Domain
{
    public class RdCancer : EntityBase<int>
    {
        public RdCancer()
        {    
        }

        public int PatId { get; set; }
        public System.DateTime OperTime { get; set; }
        public int OperId { get; set; }
        public string Code { get; set; }
        public int? LsCardType { get; set; }
        public int? LsCensus { get; set; }
        public int? IllId { get; set; }
        public int? LsIllBase { get; set; }
        public System.DateTime? DiagDate { get; set; }
        public string PathologyType { get; set; }
        public int? FormerlyIllness { get; set; }
        public System.DateTime? YDiagDate { get; set; }
        public System.DateTime? DeadDate { get; set; }
        public string DeadCause { get; set; }
        public int? IcdId { get; set; }
        public int? LocId { get; set; }
        public string F1 { get; set; }
        public string F2 { get; set; }
        public string F3 { get; set; }
        public string F4 { get; set; }
        public int? MzRegId { get; set; }
        public int? ReciOperId { get; set; }
        public string ReportUnit { get; set; }
        public System.DateTime? ReportDate { get; set; }
    }
}
