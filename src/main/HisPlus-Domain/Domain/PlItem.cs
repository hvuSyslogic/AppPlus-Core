using System.Data.Entity.ModelConfiguration;
using AppPlus.Infrastructure.Contract.Messages;

namespace HisPlus.Domain
{
    public class PlItem : EntityBase<int>
    {
        public PlItem()
        {    
        }

        public short GroupType { get; set; }
        public string Name { get; set; }
        public string Memo { get; set; }
        public short? Hours { get; set; }
        public int? ParentId { get; set; }
        public int OrderBy { get; set; }
        public bool IsActive { get; set; }
        public string F1 { get; set; }
        public string F2 { get; set; }
        public string F3 { get; set; }
        public string F4 { get; set; }
    }
}
