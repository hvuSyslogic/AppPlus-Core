using AppPlus.Infrastructure.Contract.Messages;

namespace HisPlus.Contract.Messages
{
    public class GblEmrFileDTO : DtoBase<int>
    {
        public GblEmrFileDTO()
        {
        }

        public int? LocationId { get; set; }
        public int CatalogId { get; set; }
        public string XsdFile { get; set; }
    }
}
