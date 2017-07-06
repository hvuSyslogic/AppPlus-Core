using System.Data.Entity.ModelConfiguration;
using AppPlus.Infrastructure.Contract.Messages;

namespace HisPlus.Domain
{
    public class CkLabBood : EntityBase<int>
    {
        public CkLabBood()
        {    
        }

        public int? LabId { get; set; }
        public int? BdBankId { get; set; }
    }
}
