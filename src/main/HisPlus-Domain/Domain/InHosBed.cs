using System.Data.Entity.ModelConfiguration;
using HisPlus.Infrastructure.Contract.Messages;

namespace HisPlus.Domain
{
    public class InHosBed : EntityBase<int>
    {
        public InHosBed()
        {    
        }

        public int HospId { get; set; }
        public int BedId { get; set; }
        public System.DateTime OperTime { get; set; }
        public int OperId { get; set; }
    }
}
