using AppPlus.Infrastructure.Contract.Messages;
using System.Data.Entity.ModelConfiguration;

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
        public string F1 { get; set; }
        public string F2 { get; set; }
        public string F3 { get; set; }
        public string F4 { get; set; }
    }
}
