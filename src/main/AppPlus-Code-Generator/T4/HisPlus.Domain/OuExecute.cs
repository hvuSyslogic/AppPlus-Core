using System.Data.Entity.ModelConfiguration;
using AppPlus.Infrastructure.Contract.Messages;

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
        public string F1 { get; set; }
        public string F2 { get; set; }
        public string F3 { get; set; }
        public string F4 { get; set; }
        public bool? IsExecuted { get; set; }
    }
}
