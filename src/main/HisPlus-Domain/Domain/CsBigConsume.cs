using System.Data.Entity.ModelConfiguration;
using AppPlus.Infrastructure.Contract.Messages;

namespace HisPlus.Domain
{
    public class CsBigConsume : EntityBase<int>
    {
        public CsBigConsume()
        {    
        }

        public int SubjId { get; set; }
        public int LocId { get; set; }
        public string F1 { get; set; }
        public string F2 { get; set; }
        public string F3 { get; set; }
        public string F4 { get; set; }
    }
}
