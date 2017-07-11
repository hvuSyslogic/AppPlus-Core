using AppPlus.Infrastructure.Contract.Messages;
using System.Data.Entity.ModelConfiguration;

namespace HisPlus.Domain
{
    public class RdInfectiou : EntityBase<int>
    {
        public RdInfectiou()
        {    
        }

        public int PatId { get; set; }
        public System.DateTime OperTime { get; set; }
        public int OperId { get; set; }
        public string Code { get; set; }
        public short? LsCardType { get; set; }
        public short? LsCensus { get; set; }
        public short? LsZone { get; set; }
        public string Midwife { get; set; }
        public short? LsCancelType { get; set; }
        public System.DateTime? IllDate { get; set; }
        public System.DateTime? InTime { get; set; }
        public System.DateTime? DeadDate { get; set; }
        public System.DateTime? DiagDate { get; set; }
        public short? LsPreventive { get; set; }
        public string IllIdCor { get; set; }
        public string CancelMemo { get; set; }
        public string ReportUnit { get; set; }
        public int? LocId { get; set; }
        public string Phone { get; set; }
        public string Memo { get; set; }
        public System.DateTime? ReportDate { get; set; }
        public int? JIllId { get; set; }
        public int? YIllId { get; set; }
        public int? BIllId { get; set; }
        public int? QIllId { get; set; }
        public string JName { get; set; }
        public string F1 { get; set; }
        public string F2 { get; set; }
        public string F3 { get; set; }
        public string F4 { get; set; }
        public int? MzRegId { get; set; }
        public int? ReciOperId { get; set; }
        public int? IsWrite { get; set; }
        public int? Canceloperid { get; set; }
        public int? Chkoperid { get; set; }
        public bool? Printstart { get; set; }
        public System.DateTime? ChkOperTime { get; set; }
        public System.DateTime? CancelOperTime { get; set; }
        public short? Lscanceltype2 { get; set; }
        public int? Hospid { get; set; }
        public int? WorkType { get; set; }
        public string QilLness { get; set; }
        public int? AfpId { get; set; }
    }
}
