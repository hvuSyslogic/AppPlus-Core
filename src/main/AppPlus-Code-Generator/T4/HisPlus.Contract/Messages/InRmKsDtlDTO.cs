using AppPlus.Infrastructure.Contract.Messages;

namespace HisPlus.Contract.Messages
{
    public class InRmKsDtlDTO : DtoBase<int>
    {
        public InRmKsDtlDTO()
        {
        }

        public int? DetailId { get; set; }
        public int BillId { get; set; }
        public string F1 { get; set; }
        public string F2 { get; set; }
        public string F3 { get; set; }
        public string F4 { get; set; }
    }
}
