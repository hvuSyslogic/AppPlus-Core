using AppPlus.Infrastructure.Contract.Messages;
using System.Data.Entity.ModelConfiguration;

namespace HisPlus.Domain
{
    public class InChinRicipExec : EntityBase<int>
    {
        public InChinRicipExec()
        {    
        }

        public int RecipeId { get; set; }
        public string ExecTime { get; set; }
        public string F1 { get; set; }
        public string F2 { get; set; }
        public string F3 { get; set; }
        public string F4 { get; set; }
    }
}
