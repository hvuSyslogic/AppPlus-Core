using System.Data.Entity.ModelConfiguration;
using AppPlus.Infrastructure.Contract.Messages;

namespace HisPlus.Domain
{
    public class InLogStatusIn : EntityBase<int>
    {
        public InLogStatusIn()
        {    
        }

        public int HospId { get; set; }
        public int LocationId { get; set; }
        public System.DateTime? OperTime { get; set; }
        public string F1 { get; set; }
        public string F2 { get; set; }
        public string F3 { get; set; }
        public string F4 { get; set; }
        public int? LsInIllness { get; set; }
    }
}
