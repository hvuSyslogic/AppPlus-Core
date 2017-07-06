using System;
using System.Runtime.Serialization;
using AppPlus.Infrastructure.Contract.Messages;

namespace HisPlus.Contract.Messages
{
    [Serializable]
    [DataContract]
    public class OuInvoiceDtlTempDTO : DtoBase<int>
    {
        public OuInvoiceDtlTempDTO()
        {
        }

        [DataMember]
        public decimal? Amount { get; set; }

        [DataMember]
        public decimal? AmountFact { get; set; }

        [DataMember]
        public decimal? AmountInsurance { get; set; }

        [DataMember]
        public decimal? AmountPay { get; set; }

        [DataMember]
        public decimal? AmountSelf { get; set; }

        [DataMember]
        public decimal? AmountTally { get; set; }

        [DataMember]
        public string Code { get; set; }

        [DataMember]
        public decimal? DiscDiag { get; set; }

        [DataMember]
        public decimal? DiscSelf { get; set; }

        [DataMember]
        public int? DocLevId { get; set; }

        [DataMember]
        public int? DoctorId { get; set; }

        [DataMember]
        public string DoctorName { get; set; }

        [DataMember]
        public int? ExecLocId { get; set; }

        [DataMember]
        public int? FeeHsId { get; set; }

        [DataMember]
        public string FeeHsMzName { get; set; }

        [DataMember]
        public int? FeeId { get; set; }

        [DataMember]
        public string FeeName { get; set; }

        [DataMember]
        public int? InvItemId { get; set; }

        [DataMember]
        public string InvMzItemName { get; set; }

        [DataMember]
        public int? InvoId { get; set; }

        [DataMember]
        public System.DateTime? InvoTime { get; set; }

        [DataMember]
        public bool? IsBack { get; set; }

        [DataMember]
        public bool? IsDoctorInput { get; set; }

        [DataMember]
        public bool? IsIssue { get; set; }

        [DataMember]
        public bool? IsModiDisc { get; set; }

        [DataMember]
        public bool? IsOtherFee { get; set; }

        [DataMember]
        public bool? IsPriority { get; set; }

        [DataMember]
        public bool? IsToBack { get; set; }

        [DataMember]
        public int? ItemId { get; set; }

        [DataMember]
        public decimal? LimitFee { get; set; }

        [DataMember]
        public int? LimitGroupId { get; set; }

        [DataMember]
        public decimal? LimitTotalMz { get; set; }

        [DataMember]
        public int? ListNum { get; set; }

        [DataMember]
        public string LocationName { get; set; }

        [DataMember]
        public int? LsAdviceType { get; set; }

        [DataMember]
        public int? LsGfType { get; set; }

        [DataMember]
        public int? LsGroupType { get; set; }

        [DataMember]
        public int? LsPerform { get; set; }

        [DataMember]
        public int? LsReportType { get; set; }

        [DataMember]
        public int? LsRepType { get; set; }

        [DataMember]
        public int? LsRpType { get; set; }

        [DataMember]
        public string Memo { get; set; }

        [DataMember]
        public string Name { get; set; }

        [DataMember]
        public string PrepareTime { get; set; }

        [DataMember]
        public decimal? Price { get; set; }

        [DataMember]
        public int? RecipeGroupId { get; set; }

        [DataMember]
        public string RecipeGroupIds { get; set; }

        [DataMember]
        public int? RecipeId { get; set; }

        [DataMember]
        public int? RecipeItemId { get; set; }

        [DataMember]
        public int? RoomId { get; set; }

        [DataMember]
        public string Spec { get; set; }

        [DataMember]
        public decimal? Totality { get; set; }

        [DataMember]
        public int? TypeGfxeId { get; set; }

        [DataMember]
        public string UnitDiagName { get; set; }

        [DataMember]
        public int? UnitId { get; set; }

        [DataMember]
        public int? XdRpId { get; set; }

        [DataMember]
        public int Mzregid { get; set; }

        [DataMember]
        public System.DateTime OperTime { get; set; }

        [DataMember]
        public string Usagememo { get; set; }

        [DataMember]
        public int? Usageid { get; set; }

        [DataMember]
        public int? Formid { get; set; }

        [DataMember]
        public int? Frequencyid { get; set; }
    }
}
