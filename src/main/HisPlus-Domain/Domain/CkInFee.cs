using System.Data.Entity.ModelConfiguration;
using HisPlus.Infrastructure.Contract.Messages;

namespace HisPlus.Domain
{
    public class CkInFee : EntityBase<int>
    {
        public CkInFee()
        {    
        }

        public int LabId { get; set; }
        public int? DetailId { get; set; }
    }
}
