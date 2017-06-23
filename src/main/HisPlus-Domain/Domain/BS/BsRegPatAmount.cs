using AppPlus.Infrastructure.Contract.Messages;
using System.Data.Entity.ModelConfiguration;

namespace HisPlus.Domain
{
    public class BsRegPatAmount : EntityBase<int>
    {
        public BsRegPatAmount()
        {    
        }

        public int RegTypeId { get; set; }
        public int PatTypeId { get; set; }
        public decimal RegFee { get; set; }
        public decimal DiagnoFee { get; set; }
        public decimal OtherFee1 { get; set; }
        public decimal OtherFee2 { get; set; }
        public decimal PaySel { get; set; }
        public decimal TallyFee { get; set; }
        public string F1 { get; set; }
        public string F2 { get; set; }
        public string F3 { get; set; }
        public string F4 { get; set; }
        public short IconIndex { get; set; }
    }
}
