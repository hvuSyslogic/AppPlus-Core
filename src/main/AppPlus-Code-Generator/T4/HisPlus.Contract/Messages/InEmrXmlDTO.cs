using AppPlus.Infrastructure.Contract.Messages;

namespace HisPlus.Contract.Messages
{
    public class InEmrXmlDTO : DtoBase<int>
    {
        public InEmrXmlDTO()
        {
        }

        public int HospId { get; set; }
        public System.DateTime? OperTime { get; set; }
        public int CatalogId { get; set; }
        public string XmlField { get; set; }
        public string XmlValue { get; set; }
        public string F1 { get; set; }
        public string F2 { get; set; }
        public string F3 { get; set; }
        public string F4 { get; set; }
        public int? InEmrId { get; set; }
    }
}
