using System.Data.Entity.ModelConfiguration;
using AppPlus.Infrastructure.Contract.Messages;

namespace HisPlus.Domain
{
    public class RmAdjust : EntityBase<int>
    {
        public RmAdjust()
        {    
        }

        public string BillNo { get; set; }
        public System.DateTime AdjustDate { get; set; }
        public string DispUnit { get; set; }
        public System.DateTime OperTime { get; set; }
        public int OperId { get; set; }
        public string Memo { get; set; }
    }
}
