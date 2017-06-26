using System.Data.Entity.ModelConfiguration;
using AppPlus.Infrastructure.Contract.Messages;

namespace HisPlus.Domain
{
    public class RdLiver : EntityBase<int>
    {
        public RdLiver()
        {    
        }

        public int PatId { get; set; }
        public int OperId { get; set; }
        public System.DateTime OperTime { get; set; }
        public string Code { get; set; }
        public short? LsCardType { get; set; }
        public short? LsCensus { get; set; }
        public string JName { get; set; }
        public short? LsZone { get; set; }
        public short? LsCancelType { get; set; }
        public System.DateTime? IllDate { get; set; }
        public System.DateTime? InTime { get; set; }
        public System.DateTime? DeadDate { get; set; }
        public System.DateTime? DiagDate { get; set; }
        public short? LsDiagType { get; set; }
        public short? LsPreventive { get; set; }
        public short? LsClinicType { get; set; }
        public short? LsIllSource { get; set; }
        public string Alt { get; set; }
        public string Tbil { get; set; }
        public short? LsKHavIgM { get; set; }
        public string HavRna { get; set; }
        public short? LsHbsAg { get; set; }
        public short? LsKHBs { get; set; }
        public short? LsHBeAg { get; set; }
        public short? LsKHBe { get; set; }
        public short? LsKHBc { get; set; }
        public short? LsKHBcIgM { get; set; }
        public string HbvDna { get; set; }
        public short? LsKHcv { get; set; }
        public string HcvRna { get; set; }
        public short? LsKHdvIgM { get; set; }
        public string KHdv { get; set; }
        public string HdvRna { get; set; }
        public short? LsKHevIgM { get; set; }
        public short? LsKHev { get; set; }
        public string HevRna { get; set; }
        public int? IllIdCor { get; set; }
        public string CancelMemo { get; set; }
        public string ReportUnit { get; set; }
        public int? LocId { get; set; }
        public string Phone { get; set; }
        public string Memo { get; set; }
        public System.DateTime? ReportDate { get; set; }
        public string ReportPerson { get; set; }
        public System.DateTime? JReportDate { get; set; }
        public string JReportPerson { get; set; }
        public string F1 { get; set; }
        public string F2 { get; set; }
        public string F3 { get; set; }
        public string F4 { get; set; }
        public int? MzRegId { get; set; }
        public int? ReciOperId { get; set; }
    }
}
