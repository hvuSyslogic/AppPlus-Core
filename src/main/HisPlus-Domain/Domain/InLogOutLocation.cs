using System.Data.Entity.ModelConfiguration;
using AppPlus.Infrastructure.Contract.Messages;

namespace HisPlus.Domain
{
    public class InLogOutLocation : EntityBase<int>
    {
        public InLogOutLocation()
        {    
        }

        public int HospId { get; set; }
        public int LocationId { get; set; }
        public System.DateTime? OperTime { get; set; }
        public int? InLocId { get; set; }
        public short? LsType { get; set; }
    }
}
