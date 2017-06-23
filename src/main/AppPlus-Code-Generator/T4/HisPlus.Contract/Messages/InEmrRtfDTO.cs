using AppPlus.Infrastructure.Contract.Messages;

namespace HisPlus.Contract.Messages
{
    public class InEmrRtfDTO : DtoBase<int>
    {
        public InEmrRtfDTO()
        {
        }

        public int HospId { get; set; }
        public System.DateTime? OperTime { get; set; }
        public int CatalogId { get; set; }
        public string Rtf { get; set; }
        public string F1 { get; set; }
        public string F2 { get; set; }
        public string F3 { get; set; }
        public string F4 { get; set; }
    }
}
