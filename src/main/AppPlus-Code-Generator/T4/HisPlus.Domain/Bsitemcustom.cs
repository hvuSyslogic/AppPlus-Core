using System.Data.Entity.ModelConfiguration;
using AppPlus.Infrastructure.Contract.Messages;

namespace HisPlus.Domain
{
    public class Bsitemcustom : EntityBase<int>
    {
        public Bsitemcustom()
        {    
        }

        public int Itemid { get; set; }
        public int? Reportid { get; set; }
        public string Customtype { get; set; }
        public int? Orderby { get; set; }
        public int? Iconindex { get; set; }
        public string Memo { get; set; }
        public string F1 { get; set; }
        public string F2 { get; set; }
        public string F3 { get; set; }
        public string F4 { get; set; }
    }
}
