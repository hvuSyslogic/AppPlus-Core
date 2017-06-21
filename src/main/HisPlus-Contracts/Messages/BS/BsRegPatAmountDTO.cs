using AppPlus.Infrastructure.Contract.Messages;

namespace HisPlus.Contract.Messages
{
    public class BsRegPatAmountDTO : DtoBase<int>
    {
        public BsRegPatAmountDTO()
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
