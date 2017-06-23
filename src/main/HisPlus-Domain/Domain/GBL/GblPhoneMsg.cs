using AppPlus.Infrastructure.Contract.Messages;
using System.Data.Entity.ModelConfiguration;

namespace HisPlus.Domain
{
    public class GblPhoneMsg : EntityBase<int>
    {
        public GblPhoneMsg()
        {    
        }

        public string PhoneNum { get; set; }
        public string Name { get; set; }
        public string Message { get; set; }
        public System.DateTime? PlanTime { get; set; }
        public bool? IsSend { get; set; }
        public System.DateTime? SendTime { get; set; }
        public int? OperId { get; set; }
        public System.DateTime? OperTime { get; set; }
        public string F1 { get; set; }
        public string F2 { get; set; }
        public string F3 { get; set; }
        public string F4 { get; set; }
    }
}
