using System.Data.Entity.ModelConfiguration;
using AppPlus.Infrastructure.Contract.Messages;

namespace HisPlus.Domain
{
    public class BsBaseDrug : EntityBase<int>
    {
        public BsBaseDrug()
        {    
        }

        public string Code { get; set; }
        public string Name { get; set; }
        public string PyCode { get; set; }
        public string WbCode { get; set; }
        public short OrderBy { get; set; }
        public bool IsActive { get; set; }
        public short IconIndex { get; set; }
        public decimal PriceIn { get; set; }
        public string Memo { get; set; }
        public int? GroupMainId { get; set; }
        public int? GroupSubId { get; set; }
        public int? GroupSubId2 { get; set; }
        public string EngDesc { get; set; }
        public short? LsYbType { get; set; }
        public string YbMemo { get; set; }
        public int? GroupSubId3 { get; set; }
        public int? GroupSubId4 { get; set; }
    }
}
