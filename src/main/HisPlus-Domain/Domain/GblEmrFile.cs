using System.Data.Entity.ModelConfiguration;
using AppPlus.Infrastructure.Contract.Messages;

namespace HisPlus.Domain
{
    public class GblEmrFile : EntityBase<int>
    {
        public GblEmrFile()
        {    
        }

        public int? LocationId { get; set; }
        public int CatalogId { get; set; }
        public string XsdFile { get; set; }
    }
}
