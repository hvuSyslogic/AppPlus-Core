using AppPlus.Infrastructure.Contract.Messages;
using System.Data.Entity.ModelConfiguration;

namespace HisPlus.Domain
{
    public class RdInfectStd : EntityBase<int>
    {
        public RdInfectStd()
        {    
        }

        public int PatId { get; set; }
        public System.DateTime OperTime { get; set; }
        public int OperId { get; set; }
        public string Code { get; set; }
        public short? LsCardType { get; set; }
        public int? Gestation { get; set; }
        public short? LsZone { get; set; }
        public short? LsCancelType { get; set; }
        public System.DateTime? IllDate { get; set; }
        public System.DateTime? DiagDate { get; set; }
        public System.DateTime? DeadDate { get; set; }
        public int? IllId { get; set; }
        public string LsClincSymptom { get; set; }
        public string ReportUnit { get; set; }
        public int? IllIdCor { get; set; }
        public string Memo { get; set; }
        public short? LsCTrust { get; set; }
        public short? LsCTiter { get; set; }
        public short? LsCtppa { get; set; }
        public short? LsCOther { get; set; }
        public short? LsETrust { get; set; }
        public short? LsETiter { get; set; }
        public short? LsEtppa { get; set; }
        public short? LsEIgM { get; set; }
        public string F1 { get; set; }
        public string F2 { get; set; }
        public string F3 { get; set; }
        public string F4 { get; set; }
        public string JName { get; set; }
        public int? LocId { get; set; }
        public int? MzRegId { get; set; }
        public int? ReciOperId { get; set; }
        public System.DateTime? ReportDate { get; set; }
    }
}
