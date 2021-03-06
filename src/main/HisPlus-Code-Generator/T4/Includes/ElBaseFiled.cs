using AppPlus.Infrastructure.Contract.Messages;
using System.Data.Entity.ModelConfiguration;

namespace HisPlus.Domain
{
    public class ElBaseFiled : EntityBase<int>
    {
        public ElBaseFiled()
        {    
        }

        public string Code { get; set; }
        public string Name { get; set; }
        public short? LsDataType { get; set; }
        public short? Lengh { get; set; }
        public string EditMask { get; set; }
        public string Memo { get; set; }
        public string ToolTips { get; set; }
        public string ErrorTips { get; set; }
        public bool? IsHasChild { get; set; }
        public short? OrderBy { get; set; }
        public bool? IsActive { get; set; }
        public string F1 { get; set; }
        public string F2 { get; set; }
        public string F3 { get; set; }
        public string F4 { get; set; }
        public bool? IsEncrypt { get; set; }
        public bool? IsLog { get; set; }
    }
}
