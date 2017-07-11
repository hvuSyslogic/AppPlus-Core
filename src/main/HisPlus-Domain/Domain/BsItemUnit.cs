using System.Data.Entity.ModelConfiguration;
using HisPlus.Infrastructure.Contract.Messages;

namespace HisPlus.Domain
{
    public class BsItemUnit : EntityBase<int>
    {
        public BsItemUnit()
        {    
        }

        public int ItemId { get; set; }
        public int UnitId { get; set; }
        public bool IsForYk { get; set; }
        public bool IsForYf { get; set; }
        public bool IsForRecipe { get; set; }
        public short IconIndex { get; set; }
    }
}
