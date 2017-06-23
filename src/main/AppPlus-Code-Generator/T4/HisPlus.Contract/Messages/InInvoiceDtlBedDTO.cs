using AppPlus.Infrastructure.Contract.Messages;

namespace HisPlus.Contract.Messages
{
    public class InInvoiceDtlBedDTO : DtoBase<int>
    {
        public InInvoiceDtlBedDTO()
        {
        }

        public int DetailId { get; set; }
        public int BedItemId { get; set; }
        public string F1 { get; set; }
        public string F2 { get; set; }
        public string F3 { get; set; }
        public string F4 { get; set; }
    }
}
