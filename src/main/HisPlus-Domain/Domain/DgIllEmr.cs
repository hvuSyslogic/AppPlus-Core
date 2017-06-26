using System.Data.Entity.ModelConfiguration;
using AppPlus.Infrastructure.Contract.Messages;

namespace HisPlus.Domain
{
    public class DgIllEmr : EntityBase<int>
    {
        public DgIllEmr()
        {    
        }

        public int? IcdId { get; set; }
        public string XsdFile { get; set; }
        public bool? IsBaby { get; set; }
        public bool? IsWomen { get; set; }
        public bool? IsMen { get; set; }
        public bool? IsOlder { get; set; }
        public string Memo { get; set; }
        public string F1 { get; set; }
        public string F2 { get; set; }
        public string F3 { get; set; }
        public string F4 { get; set; }
        public short IconIndex { get; set; }
    }
}
