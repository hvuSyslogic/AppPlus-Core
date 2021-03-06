using System.Data.Entity.ModelConfiguration;
using HisPlus.Infrastructure.Contract.Messages;

namespace HisPlus.Domain
{
    public class InArrearAmount : EntityBase<int>
    {
        public InArrearAmount()
        {    
        }

        public int HospId { get; set; }
        public decimal ArrearAmount { get; set; }
        public string AuthMan { get; set; }
        public string Memo { get; set; }
        public System.DateTime OperTime { get; set; }
        public int OperId { get; set; }
        public System.DateTime? ExpireDate { get; set; }
        public short? ExpireHours { get; set; }
        public bool? IsMax { get; set; }
    }
}
