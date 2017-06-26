using System.Data.Entity.ModelConfiguration;
using AppPlus.Infrastructure.Contract.Messages;

namespace HisPlus.Domain
{
    public class FtDetail : EntityBase<int>
    {
        public FtDetail()
        {    
        }

        public int BillId { get; set; }
        public int ItemId { get; set; }
        public decimal Price { get; set; }
        public decimal OrderNum { get; set; }
        public string F1 { get; set; }
        public string F2 { get; set; }
        public string F3 { get; set; }
        public string F4 { get; set; }
    }
}
