using AppPlus.Infrastructure.Contract.Messages;

namespace HisPlus.Contract.Messages
{
    public class InAdviceLongADTO : DtoBase<System.DateTime>
    {
        public InAdviceLongADTO()
        {
        }

        public int? UnitTakeId { get; set; }
        public int? FrequencyId { get; set; }
        public int? UsageId { get; set; }
        public decimal? PriceIn { get; set; }
        public System.DateTime? SkinTime { get; set; }
        public string SkinTest { get; set; }
        public System.DateTime? ChkOperTime { get; set; }
        public int? ChkOperId { get; set; }
        public System.DateTime? EndOperTime { get; set; }
        public int? EndOperId { get; set; }
        public int? EndDoctorId { get; set; }
        public System.DateTime? AuthOperTime { get; set; }
        public int? AuthOperId { get; set; }
        public string F1 { get; set; }
        public string F2 { get; set; }
        public string F3 { get; set; }
        public string F4 { get; set; }
        public bool? IsOtherFee { get; set; }
        public short? Sn { get; set; }
        public string F5 { get; set; }
        public string F6 { get; set; }
        public string F7 { get; set; }
        public short? FirstDay { get; set; }
        public short? LastDay { get; set; }
        public int? ExecLocId { get; set; }
    }
}
