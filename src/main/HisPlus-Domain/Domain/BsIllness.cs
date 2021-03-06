using System.Data.Entity.ModelConfiguration;
using HisPlus.Infrastructure.Contract.Messages;

namespace HisPlus.Domain
{
    public class BsIllness : EntityBase<int>
    {
        public BsIllness()
        {    
        }

        public string Code { get; set; }
        public string WbCode { get; set; }
        public string PyCode { get; set; }
        public string OtherCode { get; set; }
        public string Name { get; set; }
        public string OtherDesc { get; set; }
        public string GroupMain { get; set; }
        public string GroupSub { get; set; }
        public string GroupSSub { get; set; }
        public int? BelongIcd { get; set; }
        public bool IsSum { get; set; }
        public decimal? FeeHigh { get; set; }
        public short? DayHigh { get; set; }
        public int OrderBy { get; set; }
        public bool IsActive { get; set; }
        public short IconIndex { get; set; }
        public bool? IsInfectious { get; set; }
    }
}
