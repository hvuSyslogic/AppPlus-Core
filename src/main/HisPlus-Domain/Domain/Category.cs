using System.Data.Entity.ModelConfiguration;
using AppPlus.Infrastructure.Contract.Messages;

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
