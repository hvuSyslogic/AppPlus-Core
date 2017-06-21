using AppPlus.Infrastructure.Contract.Messages;

namespace HisPlus.Contract.Messages
{
    public class BsLocBranchDTO : DtoBase<int>
    {
        public BsLocBranchDTO()
        {
        }

        public int LocationId { get; set; }
        public int BranchId { get; set; }
        public string Director { get; set; }
        public string F1 { get; set; }
        public string F2 { get; set; }
        public string F3 { get; set; }
        public string F4 { get; set; }
    }
}
