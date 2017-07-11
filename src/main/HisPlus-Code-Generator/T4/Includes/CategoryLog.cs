using AppPlus.Infrastructure.Contract.Messages;
using System.Data.Entity.ModelConfiguration;

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
