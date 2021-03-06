using System.Data.Entity.ModelConfiguration;
using HisPlus.Infrastructure.Contract.Messages;

namespace HisPlus.Domain
{
    public class BsLimitGroup : EntityBase<int>
    {
        public BsLimitGroup()
        {    
        }

        public string Code { get; set; }
        public string Name { get; set; }
        public int? PatTypeId { get; set; }
        public int? TypeGfxeId { get; set; }
        public decimal LimitFeeMz { get; set; }
        public decimal LimitFeeZy { get; set; }
        public string LsLimitType { get; set; }
        public string PyCode { get; set; }
        public string WbCode { get; set; }
        public short OrderBy { get; set; }
        public bool IsActive { get; set; }
        public short IconIndex { get; set; }
        public int? DocLevelId { get; set; }
    }
}
