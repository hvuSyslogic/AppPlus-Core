using System.Data.Entity.ModelConfiguration;
using AppPlus.Infrastructure.Contract.Messages;

namespace HisPlus.Domain
{
    public class CkFormula : EntityBase<int>
    {
        public CkFormula()
        {    
        }

        public int TestId { get; set; }
        public string Formula { get; set; }
        public string Memo { get; set; }
    }
}
