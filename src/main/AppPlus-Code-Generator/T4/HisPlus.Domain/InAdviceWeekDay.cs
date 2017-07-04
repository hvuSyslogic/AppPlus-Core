using System.Data.Entity.ModelConfiguration;
using AppPlus.Infrastructure.Contract.Messages;

namespace HisPlus.Domain
{
    public class InAdviceWeekDay : EntityBase<int>
    {
        public InAdviceWeekDay()
        {    
        }

        public int AdviceId { get; set; }
        public short WeekDay { get; set; }
    }
}
