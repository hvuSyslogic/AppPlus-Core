using System.Data.Entity.ModelConfiguration;
using HisPlus.Infrastructure.Contract.Messages;

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
    }
}
