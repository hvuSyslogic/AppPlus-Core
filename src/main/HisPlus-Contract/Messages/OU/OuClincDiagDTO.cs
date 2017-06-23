using AppPlus.Infrastructure.Contract.Messages;

namespace HisPlus.Contract.Messages
{
    public class OuClincDiagDTO : DtoBase<int>
    {
        public OuClincDiagDTO()
        {
        }

        public int MzRegId { get; set; }
        public int ListNum { get; set; }
        public int? IcdId { get; set; }
        public string IllDesc { get; set; }
        public string F1 { get; set; }
        public string F2 { get; set; }
        public string F3 { get; set; }
        public string F4 { get; set; }
        public short? LsDiagType { get; set; }
        public int? SequenceNum { get; set; }
    }
}
