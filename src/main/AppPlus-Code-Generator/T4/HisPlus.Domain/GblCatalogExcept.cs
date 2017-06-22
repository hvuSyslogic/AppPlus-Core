using AppPlus.Infrastructure.Contract.Messages;
using System.Data.Entity.ModelConfiguration;

namespace HisPlus.Domain
{
    public class GblCatalogExcept : EntityBase<int>
    {
        public GblCatalogExcept()
        {    
        }

        public int CatalogId { get; set; }
        public string XmlField { get; set; }
        public bool? IsHide { get; set; }
        public string DefaultValue { get; set; }
        public bool? IsBaby { get; set; }
        public bool? IsWomen { get; set; }
        public bool? IsMen { get; set; }
        public bool? IsOlder { get; set; }
        public string Memo { get; set; }
        public string F1 { get; set; }
        public string F2 { get; set; }
        public string F3 { get; set; }
        public string F4 { get; set; }
    }
}
