using AppPlus.Infrastructure.Contract.Messages;
using System.Data.Entity.ModelConfiguration;

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
        public string F1 { get; set; }
        public string F2 { get; set; }
        public string F3 { get; set; }
        public string F4 { get; set; }
    }
}
