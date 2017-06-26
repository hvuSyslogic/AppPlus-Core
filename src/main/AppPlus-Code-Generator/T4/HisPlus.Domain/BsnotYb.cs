using System.Data.Entity.ModelConfiguration;
using AppPlus.Infrastructure.Contract.Messages;

namespace HisPlus.Domain
{
    public class BsnotYb : EntityBase<int>
    {
        public BsnotYb()
        {    
        }

        public string Code { get; set; }
        public string Name { get; set; }
        public decimal? PriceIn { get; set; }
        public string F4 { get; set; }
    }
}
