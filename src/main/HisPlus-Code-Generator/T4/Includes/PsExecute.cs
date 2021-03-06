using AppPlus.Infrastructure.Contract.Messages;
using System.Data.Entity.ModelConfiguration;

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
        public string F1 { get; set; }
        public string F2 { get; set; }
        public string F3 { get; set; }
        public string F4 { get; set; }
    }
}
