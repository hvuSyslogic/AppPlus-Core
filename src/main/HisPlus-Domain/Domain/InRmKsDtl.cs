using System.Data.Entity.ModelConfiguration;
using AppPlus.Infrastructure.Contract.Messages;

namespace HisPlus.Domain
{
    public class InRmKsDtl : EntityBase<int>
    {
        public InRmKsDtl()
        {    
        }

        public int? DetailId { get; set; }
        public int BillId { get; set; }
    }
}
