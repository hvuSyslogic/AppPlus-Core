using System.Data.Entity.ModelConfiguration;
using AppPlus.Infrastructure.Contract.Messages;

namespace HisPlus.Domain
{
    public class BsLimitDocLev : EntityBase<int>
    {
        public BsLimitDocLev()
        {    
        }

        public int LimitGroupId { get; set; }
        public int? DocLevId { get; set; }
        public string F1 { get; set; }
        public string F2 { get; set; }
        public string F3 { get; set; }
        public string F4 { get; set; }
        public int OrderBy { get; set; }
        public int? TypeGfxeId { get; set; }
        public decimal LimitFeeMz { get; set; }
        public decimal LimitFeeZy { get; set; }
        public string LsLimitType { get; set; }
        public bool IsActive { get; set; }
    }
}
