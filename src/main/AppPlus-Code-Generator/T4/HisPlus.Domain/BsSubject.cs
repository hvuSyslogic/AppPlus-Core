using System.Data.Entity.ModelConfiguration;
using AppPlus.Infrastructure.Contract.Messages;

namespace HisPlus.Domain
{
    public class BsSubject : EntityBase<int>
    {
        public BsSubject()
        {    
        }

        public string Name { get; set; }
    }
}
