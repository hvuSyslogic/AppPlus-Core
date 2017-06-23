using AppPlus.Infrastructure.Contract.Messages;
using System.Data.Entity.ModelConfiguration;

namespace HisPlus.Domain
{
    public class InRmKsDtl : EntityBase<int>
    {
        public InRmKsDtl()
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
