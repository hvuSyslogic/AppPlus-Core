using System.Data.Entity.ModelConfiguration;
using AppPlus.Infrastructure.Contract.Messages;

namespace HisPlus.Domain
{
    public class GblSystemFunction : EntityBase<int>
    {
        public GblSystemFunction()
        {    
        }

        public string Code { get; set; }
        public string Name { get; set; }
        public int OrderBy { get; set; }
    }
}
