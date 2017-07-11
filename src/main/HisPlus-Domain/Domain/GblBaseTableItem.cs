using System.Data.Entity.ModelConfiguration;
using HisPlus.Infrastructure.Contract.Messages;

namespace HisPlus.Domain
{
    public class GblBaseTableItem : EntityBase<int>
    {
        public GblBaseTableItem()
        {    
        }

        public int ParentId { get; set; }
        public string BaseTable { get; set; }
        public string Name { get; set; }
        public string BllClassName { get; set; }
        public string ModelClassName { get; set; }
        public string ConfigType { get; set; }
        public bool IsTable { get; set; }
        public short OrderBy { get; set; }
        public bool IsActive { get; set; }
        public int? RoleId { get; set; }
        public string OrderField { get; set; }
        public bool? IsToWmr { get; set; }
    }
}
