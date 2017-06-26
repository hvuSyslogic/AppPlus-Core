using System.Data.Entity.ModelConfiguration;
using AppPlus.Infrastructure.Contract.Messages;

namespace HisPlus.Domain
{
    public class InInvoiceDtlBed : EntityBase<int>
    {
        public InInvoiceDtlBed()
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
