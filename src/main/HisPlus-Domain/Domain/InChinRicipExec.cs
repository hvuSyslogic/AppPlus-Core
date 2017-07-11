using System.Data.Entity.ModelConfiguration;
using HisPlus.Infrastructure.Contract.Messages;

namespace HisPlus.Domain
{
    public class InChinRicipExec : EntityBase<int>
    {
        public InChinRicipExec()
        {    
        }

        public int RecipeId { get; set; }
        public string ExecTime { get; set; }
    }
}
