using AppPlus.Infrastructure.Contract.Messages;
using System.Data.Entity.ModelConfiguration;

namespace HisPlus.Domain
{
    public class BsAnaeItem : EntityBase<int>
    {
        public BsAnaeItem()
        {    
        }

        public int AnaeId { get; set; }
        public int ItemId { get; set; }
        public string F1 { get; set; }
        public string F2 { get; set; }
        public string F3 { get; set; }
        public string F4 { get; set; }
        public short IconIndex { get; set; }
    }
}
