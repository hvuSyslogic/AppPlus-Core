using System.Data.Entity.ModelConfiguration;
using AppPlus.Infrastructure.Contract.Messages;

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
    }
}
