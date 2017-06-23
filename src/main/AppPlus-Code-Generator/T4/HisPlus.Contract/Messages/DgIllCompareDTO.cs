using AppPlus.Infrastructure.Contract.Messages;

namespace HisPlus.Contract.Messages
{
    public class DgIllCompareDTO : DtoBase<int>
    {
        public DgIllCompareDTO()
        {
        }

        public int? IcdId1 { get; set; }
        public int? IcdId2 { get; set; }
        public string Memo { get; set; }
        public string F1 { get; set; }
        public string F2 { get; set; }
        public string F3 { get; set; }
        public string F4 { get; set; }
        public short IconIndex { get; set; }
    }
}
