using AppPlus.Infrastructure.Contract.Messages;
using System.Data.Entity.ModelConfiguration;

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
        public string F1 { get; set; }
        public string F2 { get; set; }
        public string F3 { get; set; }
        public string F4 { get; set; }
        public bool? IsToWmr { get; set; }
    }
}
