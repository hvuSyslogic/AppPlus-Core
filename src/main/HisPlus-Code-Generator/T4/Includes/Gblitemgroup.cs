using AppPlus.Infrastructure.Contract.Messages;
using System.Data.Entity.ModelConfiguration;

namespace HisPlus.Domain
{
    public class Gblitemgroup : EntityBase<int>
    {
        public Gblitemgroup()
        {    
        }

        public string Code { get; set; }
        public string Name { get; set; }
        public string F1 { get; set; }
        public string F2 { get; set; }
        public string F3 { get; set; }
        public string F4 { get; set; }
    }
}
