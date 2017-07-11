using AppPlus.Infrastructure.Contract.Messages;
using System.Data.Entity.ModelConfiguration;

namespace HisPlus.Domain
{
    public class Gblitemgroupdtl : EntityBase<int>
    {
        public Gblitemgroupdtl()
        {    
        }

        public int Groupid { get; set; }
        public int Itemid { get; set; }
        public string F1 { get; set; }
        public string F2 { get; set; }
        public string F3 { get; set; }
        public string F4 { get; set; }
    }
}
