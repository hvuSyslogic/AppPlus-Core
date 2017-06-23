using AppPlus.Infrastructure.Contract.Messages;
using System.Data.Entity.ModelConfiguration;

namespace HisPlus.Domain
{
    public class RdBrainDead : EntityBase<int>
    {
        public RdBrainDead()
        {    
        }

        public int PatId { get; set; }
        public System.DateTime OperTime { get; set; }
        public int OperId { get; set; }
        public string Code { get; set; }
        public int? IcdId { get; set; }
        public short? LsCardType { get; set; }
        public short? LsCensus { get; set; }
        public int? IllId { get; set; }
        public System.DateTime? DiagDate { get; set; }
        public short? LsIllBase { get; set; }
        public string LsIllType { get; set; }
        public System.DateTime? IllDate { get; set; }
        public short? LsLastTime { get; set; }
        public int? IllTimes { get; set; }
        public System.DateTime? DeadDate { get; set; }
        public string ImmediacyDead { get; set; }
        public string ElseIllness { get; set; }
        public string FormerlyIllness { get; set; }
        public System.DateTime? YDiagDate { get; set; }
        public string DeadCause { get; set; }
        public int? LocId { get; set; }
        public int? DeadIcd { get; set; }
        public int? ElseIllnessIcd { get; set; }
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
