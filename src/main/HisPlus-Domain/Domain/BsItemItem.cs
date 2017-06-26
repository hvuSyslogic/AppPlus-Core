using System.Data.Entity.ModelConfiguration;
using AppPlus.Infrastructure.Contract.Messages;

namespace HisPlus.Domain
{
    public class BsItemItem : EntityBase<int>
    {
        public BsItemItem()
        {    
        }

        public int ItemId1 { get; set; }
        public int ItemId2 { get; set; }
        public bool IsReject { get; set; }
        public string F1 { get; set; }
        public string F2 { get; set; }
        public string F3 { get; set; }
        public string F4 { get; set; }
        public short IconIndex { get; set; }
    }
}
