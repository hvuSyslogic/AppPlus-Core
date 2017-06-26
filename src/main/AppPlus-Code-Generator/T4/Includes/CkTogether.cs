using AppPlus.Infrastructure.Contract.Messages;
using System.Data.Entity.ModelConfiguration;

namespace HisPlus.Domain
{
    public class CkTogether : EntityBase<int>
    {
        public CkTogether()
        {    
        }

        public int TestId1 { get; set; }
        public int? TestId2 { get; set; }
        public string F1 { get; set; }
        public string F2 { get; set; }
        public string F3 { get; set; }
        public string F4 { get; set; }
    }
}
