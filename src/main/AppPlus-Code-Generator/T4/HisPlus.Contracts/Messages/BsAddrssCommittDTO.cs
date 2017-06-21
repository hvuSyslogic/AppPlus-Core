using AppPlus.Infrastructure.Contract.Messages;

namespace HisPlus.Contract.Messages
{
    public class BsAddrssCommittDTO : DtoBase<int>
    {
        public BsAddrssCommittDTO()
        {
        }

        public string AdrressKey { get; set; }
        public int CommitteeId { get; set; }
        public string F1 { get; set; }
        public string F2 { get; set; }
        public string F3 { get; set; }
        public string F4 { get; set; }
        public short IconIndex { get; set; }
    }
}
