using AppPlus.Infrastructure.Contract.Messages;
using System.Data.Entity.ModelConfiguration;

namespace HisPlus.Domain
{
    public class CkGroupItem : EntityBase<int>
    {
        public CkGroupItem()
        {    
        }

        public int CompanyGroupId { get; set; }
        public int TestId { get; set; }
        public int ParentId { get; set; }
        public string ItemId { get; set; }
        public string AppId { get; set; }
        public string F1 { get; set; }
        public string F2 { get; set; }
        public string F3 { get; set; }
        public string F4 { get; set; }
    }
}
