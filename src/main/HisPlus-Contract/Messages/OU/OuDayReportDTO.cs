using AppPlus.Infrastructure.Contract.Messages;

namespace HisPlus.Contract.Messages
{
    public class OuDayReportDTO : DtoBase<int>
    {
        public OuDayReportDTO()
        {
        }

        public string RtpNo { get; set; }
        public System.DateTime OperTime { get; set; }
        public int OperId { get; set; }
        public string Remark { get; set; }
        public decimal Beprice { get; set; }
        public decimal FactGet { get; set; }
        public decimal? InArrear { get; set; }
        public string F1 { get; set; }
        public string F2 { get; set; }
        public string F3 { get; set; }
        public string F4 { get; set; }
    }
}
