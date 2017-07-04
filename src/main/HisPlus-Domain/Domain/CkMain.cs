using System.Data.Entity.ModelConfiguration;
using AppPlus.Infrastructure.Contract.Messages;

namespace HisPlus.Domain
{
    public class CkMain : EntityBase<int>
    {
        public CkMain()
        {    
        }

        public string CheckNo { get; set; }
        public int PatId { get; set; }
        public System.DateTime CheckTime { get; set; }
        public int? CompanyCkeckId { get; set; }
        public int? LocationId { get; set; }
        public int? DoctorId { get; set; }
        public System.DateTime OperTime { get; set; }
        public int OperId { get; set; }
        public bool IsCancel { get; set; }
        public System.DateTime? CancelOperTime { get; set; }
        public int? CancelOperId { get; set; }
        public string CancelMemo { get; set; }
        public System.DateTime? RecieveTime { get; set; }
        public int? RecieveOperId { get; set; }
        public System.DateTime? ReportTime { get; set; }
        public int? ReportOperId { get; set; }
        public short? LsStatus { get; set; }
        public string ReportMemo { get; set; }
        public string TechMemo { get; set; }
        public string OtherMemo { get; set; }
        public int? CompanyId { get; set; }
        public int? CompanyGroupId { get; set; }
        public string RptFileName { get; set; }
        public bool? IsPay { get; set; }
    }
}
