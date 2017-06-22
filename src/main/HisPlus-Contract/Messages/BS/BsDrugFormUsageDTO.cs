using AppPlus.Infrastructure.Contract.Messages;

namespace HisPlus.Contract.Messages
{
    public class BsDrugFormUsageDTO : DtoBase<int>
    {
        public BsDrugFormUsageDTO()
        {
        }

        public int FormId { get; set; }
        public int UsageId { get; set; }
        public string F1 { get; set; }
        public string F2 { get; set; }
        public string F3 { get; set; }
        public string F4 { get; set; }
        public short IconIndex { get; set; }
    }
}
