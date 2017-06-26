using System;
using System.Runtime.Serialization;
using AppPlus.Infrastructure.Contract.Messages;

namespace HisPlus.Contract.Messages
{
    [Serializable]
    [DataContract]
    public class OuHosInfoDTO : DtoBase<int>
    {
        public OuHosInfoDTO()
        {
        }

        [DataMember]
        public string MzRegNo { get; set; }

        [DataMember]
        public System.DateTime RegTime { get; set; }

        [DataMember]
        public int PatId { get; set; }

        [DataMember]
        public string CardNo { get; set; }

        [DataMember]
        public string Name { get; set; }

        [DataMember]
        public string Sex { get; set; }

        [DataMember]
        public bool IsBaby { get; set; }

        [DataMember]
        public short? AgeDay { get; set; }

        [DataMember]
        public decimal? Height { get; set; }

        [DataMember]
        public decimal? Weight { get; set; }

        [DataMember]
        public int PatTypeId { get; set; }

        [DataMember]
        public string MedicareNo { get; set; }

        [DataMember]
        public int RegTypeId { get; set; }

        [DataMember]
        public bool IsPriority { get; set; }

        [DataMember]
        public bool IsElder { get; set; }

        [DataMember]
        public int LineOrder { get; set; }

        [DataMember]
        public decimal RegFee { get; set; }

        [DataMember]
        public decimal ZyFee { get; set; }

        [DataMember]
        public decimal DiagnoFee { get; set; }

        [DataMember]
        public decimal OtherFee1 { get; set; }

        [DataMember]
        public decimal OtherFee2 { get; set; }

        [DataMember]
        public decimal PaySel { get; set; }

        [DataMember]
        public decimal TallyDiag { get; set; }

        [DataMember]
        public decimal FactGet { get; set; }

        [DataMember]
        public int RegDept { get; set; }

        [DataMember]
        public int? DiagnDept { get; set; }

        [DataMember]
        public int? DoctorId { get; set; }

        [DataMember]
        public string RoomNo { get; set; }

        [DataMember]
        public bool IsFreeDiag { get; set; }

        [DataMember]
        public bool IsFreeReg { get; set; }

        [DataMember]
        public bool IsInPatient { get; set; }

        [DataMember]
        public bool IsPreReg { get; set; }

        [DataMember]
        public System.DateTime OperTime { get; set; }

        [DataMember]
        public int OperId { get; set; }

        [DataMember]
        public bool? IsCancel { get; set; }

        [DataMember]
        public System.DateTime? CancelTime { get; set; }

        [DataMember]
        public int? CancelOperId { get; set; }

        [DataMember]
        public string CancelMemo { get; set; }

        [DataMember]
        public string F1 { get; set; }

        [DataMember]
        public string F2 { get; set; }

        [DataMember]
        public string F3 { get; set; }

        [DataMember]
        public string F4 { get; set; }

        [DataMember]
        public int? TimeSpanId { get; set; }

        [DataMember]
        public string RegDate { get; set; }

        [DataMember]
        public byte? Age { get; set; }

        [DataMember]
        public string AgeString { get; set; }

        [DataMember]
        public string ContactPhone { get; set; }

        [DataMember]
        public string LinkmanName { get; set; }

        [DataMember]
        public System.DateTime? TallyTime { get; set; }

        [DataMember]
        public System.DateTime? CancelTallyTime { get; set; }

        [DataMember]
        public string F5 { get; set; }

        [DataMember]
        public string F6 { get; set; }

        [DataMember]
        public string F7 { get; set; }

        [DataMember]
        public string F8 { get; set; }

        [DataMember]
        public int? TimeSpanSubId { get; set; }

        [DataMember]
        public int? DiagRoomId { get; set; }

        [DataMember]
        public int? CallDoctorId { get; set; }

        [DataMember]
        public int? CallOrder { get; set; }

        [DataMember]
        public bool? IsFirstCheck { get; set; }

        [DataMember]
        public bool? IsGoodRecipe { get; set; }

        [DataMember]
        public string GoodRecipe { get; set; }

        [DataMember]
        public bool? IsRegist { get; set; }
    }
}
