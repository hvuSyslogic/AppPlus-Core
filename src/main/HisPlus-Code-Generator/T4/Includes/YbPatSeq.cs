using AppPlus.Infrastructure.Contract.Messages;
using System.Data.Entity.ModelConfiguration;

namespace HisPlus.Domain
{
    public class YbPatSeq : EntityBase<int>
    {
        public YbPatSeq()
        {    
        }

        public int? MzRegId { get; set; }
        public int? HospId { get; set; }
        public string YbSeq { get; set; }
        public string F1 { get; set; }
        public string F2 { get; set; }
        public string F3 { get; set; }
        public string F4 { get; set; }
        public string F5 { get; set; }
        public string F6 { get; set; }
        public string F7 { get; set; }
        public string F8 { get; set; }
    }
}
