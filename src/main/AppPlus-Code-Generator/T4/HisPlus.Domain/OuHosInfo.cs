using System.Data.Entity.ModelConfiguration;
using AppPlus.Infrastructure.Contract.Messages;

namespace HisPlus.Domain
{
    public class OuHosInfo : EntityBase<int>
    {
        public OuHosInfo()
        {    
        }

        public string MzRegNo { get; set; }
        public System.DateTime RegTime { get; set; }
        public int PatId { get; set; }
        public string CardNo { get; set; }
        public string Name { get; set; }
        public string Sex { get; set; }
        public bool IsBaby { get; set; }
        public short? AgeDay { get; set; }
        public decimal? Height { get; set; }
        public decimal? Weight { get; set; }
        public int PatTypeId { get; set; }
        public string MedicareNo { get; set; }
        public int RegTypeId { get; set; }
        public bool IsPriority { get; set; }
        public bool IsElder { get; set; }
        public int LineOrder { get; set; }
        public decimal RegFee { get; set; }
        public decimal ZyFee { get; set; }
        public decimal DiagnoFee { get; set; }
        public decimal OtherFee1 { get; set; }
        public decimal OtherFee2 { get; set; }
        public decimal PaySel { get; set; }
        public decimal TallyDiag { get; set; }
        public decimal FactGet { get; set; }
        public int RegDept { get; set; }
        public int? DiagnDept { get; set; }
        public int? DoctorId { get; set; }
        public string RoomNo { get; set; }
        public bool IsFreeDiag { get; set; }
        public bool IsFreeReg { get; set; }
        public bool IsInPatient { get; set; }
        public bool IsPreReg { get; set; }
        public System.DateTime OperTime { get; set; }
        public int OperId { get; set; }
        public bool? IsCancel { get; set; }
        public System.DateTime? CancelTime { get; set; }
        public int? CancelOperId { get; set; }
        public string CancelMemo { get; set; }
        public int? TimeSpanId { get; set; }
        public string RegDate { get; set; }
        public byte? Age { get; set; }
        public string AgeString { get; set; }
        public string ContactPhone { get; set; }
        public string LinkmanName { get; set; }
        public System.DateTime? TallyTime { get; set; }
        public System.DateTime? CancelTallyTime { get; set; }
        public int? TimeSpanSubId { get; set; }
        public int? DiagRoomId { get; set; }
        public int? CallDoctorId { get; set; }
        public int? CallOrder { get; set; }
        public bool? IsFirstCheck { get; set; }
        public bool? IsGoodRecipe { get; set; }
        public string GoodRecipe { get; set; }
        public bool? IsRegist { get; set; }
        public string Diagnose { get; set; }
        public string PreRegRegWay { get; set; }
        public bool? IsRegister { get; set; }
    }
}
