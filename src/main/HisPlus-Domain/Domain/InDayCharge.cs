using System.Data.Entity.ModelConfiguration;
using HisPlus.Infrastructure.Contract.Messages;

namespace HisPlus.Domain
{
    public class InDayCharge : EntityBase<int>
    {
        public InDayCharge()
        {    
        }

        public int ItemId { get; set; }
        public int? PatTypeId { get; set; }
        public int? LocationId { get; set; }
        public string BeginTime { get; set; }
        public decimal Totality { get; set; }
        public int UnitId { get; set; }
    }
}
