using System.Data.Entity.ModelConfiguration;
using HisPlus.Infrastructure.Contract.Messages;

namespace HisPlus.Domain
{
    public class BsPatType : EntityBase<int>
    {
        public BsPatType()
        {    
        }

        public string Code { get; set; }
        public string Name { get; set; }
        public decimal LimitFee { get; set; }
        public decimal LimitIn { get; set; }
        public decimal ArrearFei { get; set; }
        public decimal DiscDiag { get; set; }
        public decimal DiscIn { get; set; }
        public string HeadNo { get; set; }
        public int TallyTypeId { get; set; }
        public decimal ArrearAmount { get; set; }
        public short? LsGfPatType { get; set; }
        public string WbCode { get; set; }
        public string PyCode { get; set; }
        public bool IsActive { get; set; }
        public short OrderBy { get; set; }
        public short IconIndex { get; set; }
        public decimal? TwoDiscIn1 { get; set; }
        public decimal? TwoDiscIn2 { get; set; }
    }
}
