using System.Data.Entity.ModelConfiguration;
using HisPlus.Infrastructure.Contract.Messages;

namespace HisPlus.Domain
{
    public class OuExecute : EntityBase<int>
    {
        public OuExecute()
        {    
        }

        public int MzRegId { get; set; }
        public short LsRepType { get; set; }
        public string Name { get; set; }
        public int RecipeId { get; set; }
        public short GroupNum { get; set; }
        public short NDay { get; set; }
        public short NTime { get; set; }
        public int UsageId { get; set; }
        public bool? IsExecuted { get; set; }
    }
}
