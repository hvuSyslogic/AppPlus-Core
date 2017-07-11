using System.Data.Entity.ModelConfiguration;
using HisPlus.Infrastructure.Contract.Messages;

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
    }
}
