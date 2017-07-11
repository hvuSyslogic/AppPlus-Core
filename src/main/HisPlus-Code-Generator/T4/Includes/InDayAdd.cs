using AppPlus.Infrastructure.Contract.Messages;
using System.Data.Entity.ModelConfiguration;

namespace HisPlus.Domain
{
    public class InDayAdd : EntityBase<int>
    {
        public InDayAdd()
        {    
        }

        public int HospId { get; set; }
        public int ItemId { get; set; }
        public string BeginTime { get; set; }
        public decimal Totality { get; set; }
        public int UnitId { get; set; }
        public string F1 { get; set; }
        public string F2 { get; set; }
        public string F3 { get; set; }
        public string F4 { get; set; }
    }
}
