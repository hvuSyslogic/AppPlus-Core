using System.Data.Entity.ModelConfiguration;
using HisPlus.Infrastructure.Contract.Messages;

namespace HisPlus.Domain
{
    public class InOutLocation : EntityBase<int>
    {
        public InOutLocation()
        {    
        }

        public int HospId { get; set; }
        public int BedId { get; set; }
        public int OutLocId { get; set; }
        public System.DateTime? OutOperTime { get; set; }
        public int? OutOperId { get; set; }
        public bool? IsReceived { get; set; }
        public int? InLocId { get; set; }
        public System.DateTime? InOperTime { get; set; }
        public int? InOperId { get; set; }
    }
}
