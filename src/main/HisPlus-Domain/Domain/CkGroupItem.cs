using System.Data.Entity.ModelConfiguration;
using HisPlus.Infrastructure.Contract.Messages;

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
    }
}
