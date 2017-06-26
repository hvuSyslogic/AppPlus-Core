using System.Data.Entity.ModelConfiguration;
using AppPlus.Infrastructure.Contract.Messages;

namespace HisPlus.Domain
{
    public class GblCatalogKey : EntityBase<int>
    {
        public GblCatalogKey()
        {    
        }

        public int CatalogId { get; set; }
        public string XmlField { get; set; }
        public string KeyFile { get; set; }
        public string TmpWord { get; set; }
        public string F1 { get; set; }
        public string F2 { get; set; }
        public string F3 { get; set; }
        public string F4 { get; set; }
    }
}
