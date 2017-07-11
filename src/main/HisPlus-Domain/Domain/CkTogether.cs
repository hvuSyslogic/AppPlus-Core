using System.Data.Entity.ModelConfiguration;
using HisPlus.Infrastructure.Contract.Messages;

namespace HisPlus.Domain
{
    public class CkTogether : EntityBase<int>
    {
        public CkTogether()
        {    
        }

        public int TestId1 { get; set; }
        public int? TestId2 { get; set; }
    }
}
