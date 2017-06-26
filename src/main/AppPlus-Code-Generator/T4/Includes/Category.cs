using AppPlus.Infrastructure.Contract.Messages;
using System.Data.Entity.ModelConfiguration;

namespace HisPlus.Domain
{
    public class Category : EntityBase<int>
    {
        public Category()
        {    
        }

        public string CategoryName { get; set; }
    }
}
