using System.Data.Entity.ModelConfiguration;
using AppPlus.Infrastructure.Contract.Messages;

namespace HisPlus.Domain
{
    public class GblCatalogJoin : EntityBase<int>
    {
        public GblCatalogJoin()
        {    
        }

        public int CatalogId1 { get; set; }
        public string XmlField1 { get; set; }
        public int CatalogId2 { get; set; }
        public string XmlField2 { get; set; }
    }
}
