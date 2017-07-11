using System.Data.Entity.ModelConfiguration;
using HisPlus.Infrastructure.Contract.Messages;

namespace HisPlus.Domain
{
    public class InDayAdd : EntityBase<int>
    {
        public InDayAdd()
        {    
        }

        public int HospId { get; set; }
        public int ItemId { get; set; }
        public string BeginTime { get; set; }
        public decimal Totality { get; set; }
        public int UnitId { get; set; }
    }
}
