using AppPlus.Infrastructure.Contract.Messages;
using System.Data.Entity.ModelConfiguration;

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
        public string F1 { get; set; }
        public string F2 { get; set; }
        public string F3 { get; set; }
        public string F4 { get; set; }
    }
}
