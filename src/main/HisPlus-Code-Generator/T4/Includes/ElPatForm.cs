using AppPlus.Infrastructure.Contract.Messages;
using System.Data.Entity.ModelConfiguration;

namespace HisPlus.Domain
{
    public class ElPatForm : EntityBase<int>
    {
        public ElPatForm()
        {    
        }

        public int? PatId { get; set; }
        public int? HospitalId { get; set; }
        public int PatMenuId { get; set; }
        public int? RecId { get; set; }
        public string Memo { get; set; }
        public System.DateTime OperTime { get; set; }
        public int OperId { get; set; }
        public bool? IsAuth { get; set; }
        public System.DateTime? AuthTime { get; set; }
        public string RejectReason { get; set; }
        public bool IsActive { get; set; }
        public string InActiveReason { get; set; }
        public System.DateTime? InActiveTime { get; set; }
        public int? InActiveOperId { get; set; }
        public string F1 { get; set; }
        public string F2 { get; set; }
        public string F3 { get; set; }
        public string F4 { get; set; }
    }
}
