using System.Data.Entity.ModelConfiguration;
using HisPlus.Infrastructure.Contract.Messages;

namespace HisPlus.Domain
{
    public class BsUnitRatio : EntityBase<int>
    {
        public BsUnitRatio()
        {    
        }

        public int ItemId { get; set; }
        public int UnitId1 { get; set; }
        public int UnitId2 { get; set; }
        public decimal DrugRatio { get; set; }
        public short IconIndex { get; set; }
    }
}
