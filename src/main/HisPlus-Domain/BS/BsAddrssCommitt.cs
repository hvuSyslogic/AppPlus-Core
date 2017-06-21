using AppPlus.Infrastructure.Contract.Messages;
using System.Data.Entity.ModelConfiguration;

namespace HisPlus.Domain
{
    public class BsAddrssCommitt : EntityBase<int>
    {
        public BsAddrssCommitt()
        {    
        }

        public string AdrressKey { get; set; }
        public int CommitteeId { get; set; }
        public string F1 { get; set; }
        public string F2 { get; set; }
        public string F3 { get; set; }
        public string F4 { get; set; }
        public short IconIndex { get; set; }
    }
}
