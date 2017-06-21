using AppPlus.Infrastructure.Contract.Messages;

namespace HisPlus.Contract.Messages
{
    public class BsItemFrequencyDTO : DtoBase<int>
    {
        public BsItemFrequencyDTO()
        {
        }

        public int ItemId { get; set; }
        public int FrequencyId { get; set; }
        public string F1 { get; set; }
        public string F2 { get; set; }
        public string F3 { get; set; }
        public string F4 { get; set; }
        public short IconIndex { get; set; }
    }
}
