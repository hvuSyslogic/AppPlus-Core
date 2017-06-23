using AppPlus.Infrastructure.Contract.Messages;

namespace HisPlus.Contract.Messages
{
    public class InAdviceTempADTO : DtoBase<System.DateTime>
    {
        public InAdviceTempADTO()
        {
        }

        public int? UnitTakeId { get; set; }
        public int? FrequencyId { get; set; }
        public int? UsageId { get; set; }
        public System.DateTime? SkinTime { get; set; }
        public string SkinTest { get; set; }
        public bool? IsOtherFee { get; set; }
        public System.DateTime? ChkOperTime { get; set; }
        public int? ChkOperId { get; set; }
        public System.DateTime? AuthOperTime { get; set; }
        public int? AuthOperId { get; set; }
        public System.DateTime? AuthFeeOperTime { get; set; }
        public int? AuthFeeOperId { get; set; }
        public System.DateTime? CancelOperTime { get; set; }
        public int? CancelOperId { get; set; }
        public string F1 { get; set; }
        public string F2 { get; set; }
        public string F3 { get; set; }
        public string F4 { get; set; }
        public short? Sn { get; set; }
        public string F5 { get; set; }
        public string F6 { get; set; }
        public string F7 { get; set; }
        public int? ExecLocId { get; set; }
    }
}
