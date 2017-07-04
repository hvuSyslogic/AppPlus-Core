using System.Data.Entity.ModelConfiguration;
using AppPlus.Infrastructure.Contract.Messages;

namespace HisPlus.Domain
{
    public class GblModule : EntityBase<int>
    {
        public GblModule()
        {    
        }

        public int? FunctionId { get; set; }
        public int? MenuId { get; set; }
        public int OrderBy { get; set; }
        public string Memo { get; set; }
    }
}
