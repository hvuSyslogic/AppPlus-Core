using System.Data.Entity.ModelConfiguration;
using HisPlus.Infrastructure.Contract.Messages;

namespace HisPlus.Domain
{
    public class InCallBack : EntityBase<int>
    {
        public InCallBack()
        {    
        }

        public int? LocationId { get; set; }
        public int HospId { get; set; }
        public System.DateTime BackTime { get; set; }
        public string Reason { get; set; }
        public System.DateTime OperTime { get; set; }
        public int? OperId { get; set; }
    }
}
