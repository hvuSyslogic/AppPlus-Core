using System.Data.Entity.ModelConfiguration;
using AppPlus.Infrastructure.Contract.Messages;

namespace HisPlus.Domain
{
    public class Bsitemcustomgroup : EntityBase<int>
    {
        public Bsitemcustomgroup()
        {    
        }

        public string Name { get; set; }
        public int Orderby { get; set; }
        public int Isactive { get; set; }
        public int Lsoutorin { get; set; }
        public string F1 { get; set; }
        public string F2 { get; set; }
        public string F3 { get; set; }
        public string F4 { get; set; }
        public int Iconindex { get; set; }
    }
}
