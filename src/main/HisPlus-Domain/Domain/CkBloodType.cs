using System.Data.Entity.ModelConfiguration;
using AppPlus.Infrastructure.Contract.Messages;

namespace HisPlus.Domain
{
    public class CkBloodType : EntityBase<int>
    {
        public CkBloodType()
        {    
        }

        public string Code { get; set; }
        public string Name { get; set; }
        public decimal PriceIn { get; set; }
        public decimal PriceOut { get; set; }
        public short LimitDays { get; set; }
        public int UnitId { get; set; }
        public string PyCode { get; set; }
        public string WbCode { get; set; }
        public short OrderBy { get; set; }
        public bool IsActive { get; set; }
        public short IconIndex { get; set; }
        public decimal? UnderLineKc { get; set; }
    }
}
