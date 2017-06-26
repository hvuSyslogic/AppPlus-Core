using System.Data.Entity.ModelConfiguration;
using AppPlus.Infrastructure.Contract.Messages;

namespace HisPlus.Domain
{
    public class DgIllGroup : EntityBase<int>
    {
        public DgIllGroup()
        {    
        }

        public int? IcdId { get; set; }
        public string GroupDesc { get; set; }
        public string F1 { get; set; }
        public string F2 { get; set; }
        public string F3 { get; set; }
        public string F4 { get; set; }
        public short IconIndex { get; set; }
    }
}
