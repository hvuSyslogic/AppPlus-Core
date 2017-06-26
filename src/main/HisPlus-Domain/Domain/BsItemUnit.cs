using System.Data.Entity.ModelConfiguration;
using AppPlus.Infrastructure.Contract.Messages;

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
        public string F1 { get; set; }
        public string F2 { get; set; }
        public string F3 { get; set; }
        public string F4 { get; set; }
        public short IconIndex { get; set; }
    }
}
