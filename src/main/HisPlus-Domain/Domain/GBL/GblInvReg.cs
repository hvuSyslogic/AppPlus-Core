using AppPlus.Infrastructure.Contract.Messages;
using System.Data.Entity.ModelConfiguration;

namespace HisPlus.Domain
{
    public class GblInvReg : EntityBase<int>
    {
        public GblInvReg()
        {    
        }

        public string InvType { get; set; }
        public string Name { get; set; }
        public string StartInvoNo { get; set; }
        public string EndInvoNo { get; set; }
        public bool IsEnd { get; set; }
        public System.DateTime? EndTime { get; set; }
        public System.DateTime OperTime { get; set; }
        public int OperId { get; set; }
        public string F1 { get; set; }
        public string F2 { get; set; }
        public string F3 { get; set; }
        public string F4 { get; set; }
    }
}
