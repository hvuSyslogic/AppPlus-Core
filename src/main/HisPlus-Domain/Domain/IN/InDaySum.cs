using AppPlus.Infrastructure.Contract.Messages;
using System.Data.Entity.ModelConfiguration;

namespace HisPlus.Domain
{
    public class InDaySum : EntityBase<int>
    {
        public InDaySum()
        {    
        }

        public int HospId { get; set; }
        public System.DateTime RegDate { get; set; }
        public decimal NotPay { get; set; }
        public decimal HasPay { get; set; }
        public decimal DaySum { get; set; }
        public string F1 { get; set; }
        public string F2 { get; set; }
        public string F3 { get; set; }
        public string F4 { get; set; }
        public decimal? Remain { get; set; }
    }
}
