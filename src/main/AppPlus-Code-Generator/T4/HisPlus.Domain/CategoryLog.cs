using System.Data.Entity.ModelConfiguration;
using AppPlus.Infrastructure.Contract.Messages;

namespace HisPlus.Domain
{
    public class CategoryLog : EntityBase<int>
    {
        public CategoryLog()
        {    
        }

        public int CategoryId { get; set; }
        public int LogId { get; set; }
    }
}
