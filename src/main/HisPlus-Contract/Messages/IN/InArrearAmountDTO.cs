using AppPlus.Infrastructure.Contract.Messages;

namespace HisPlus.Contract.Messages
{
    public class InArrearAmountDTO : DtoBase<int>
    {
        public InArrearAmountDTO()
        {
        }

        public int HospId { get; set; }
        public decimal ArrearAmount { get; set; }
        public string AuthMan { get; set; }
        public string Memo { get; set; }
        public System.DateTime OperTime { get; set; }
        public int OperId { get; set; }
        public string F1 { get; set; }
        public string F2 { get; set; }
        public string F3 { get; set; }
        public string F4 { get; set; }
        public System.DateTime? ExpireDate { get; set; }
        public short? ExpireHours { get; set; }
        public bool? IsMax { get; set; }
    }
}
