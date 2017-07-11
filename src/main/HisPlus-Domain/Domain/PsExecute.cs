using System.Data.Entity.ModelConfiguration;
using HisPlus.Infrastructure.Contract.Messages;

namespace HisPlus.Domain
{
    public class PsExecute : EntityBase<int>
    {
        public PsExecute()
        {    
        }

        public string ApplyId { get; set; }
        public int? RecipeId { get; set; }
        public bool? IsExecuted { get; set; }
        public System.DateTime? ExecutedTime { get; set; }
        public int? ExecutedOperId { get; set; }
        public int? ExecLocId { get; set; }
    }
}
