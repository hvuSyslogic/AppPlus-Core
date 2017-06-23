using AppPlus.Infrastructure.Contract.Messages;

namespace HisPlus.Contract.Messages
{
    public class InpatfeeslistJDTO : DtoBase<int>
    {
        public InpatfeeslistJDTO()
        {
        }

        public string Name { get; set; }
        public int? BedId { get; set; }
        public System.DateTime? OutTime { get; set; }
        public int? LocationId { get; set; }
        public int? LocIn { get; set; }
        public int? DoctorId { get; set; }
        public decimal? Amount { get; set; }
        public decimal? AmountPay { get; set; }
        public decimal? Deposit { get; set; }
        public decimal? NotPay { get; set; }
        public decimal? HasPay { get; set; }
        public decimal? Remain { get; set; }
        public System.DateTime? OperTime { get; set; }
        public string F1 { get; set; }
        public string F2 { get; set; }
        public string F3 { get; set; }
        public string F4 { get; set; }
        public string InPatNo { get; set; }
        public decimal? AmountNoPay { get; set; }
        public decimal? AmountPayNoPay { get; set; }
        public decimal? DepositNoPay { get; set; }
        public decimal? DepositMz { get; set; }
        public decimal? FactGet { get; set; }
        public decimal? AllFactGet { get; set; }
    }
}
