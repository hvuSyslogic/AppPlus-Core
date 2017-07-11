using System;
using System.Runtime.Serialization;
using HisPlus.Infrastructure.Contract.Messages;

namespace HisPlus.Contract.Messages
{
    [Serializable]
    [DataContract]
    public class BsItemDTO : DtoBase<int>
    {
        public BsItemDTO()
        {
        }

        [DataMember]
        public short LsGroupType { get; set; }

        [DataMember]
        public string Code { get; set; }

        [DataMember]
        public string WbCode { get; set; }

        [DataMember]
        public string PyCode { get; set; }

        [DataMember]
        public string StrokeCode { get; set; }

        [DataMember]
        public string OtherCode { get; set; }

        [DataMember]
        public int GroupMainId { get; set; }

        [DataMember]
        public int? GroupSubId { get; set; }

        [DataMember]
        public string Name { get; set; }

        [DataMember]
        public string LongDesc { get; set; }

        [DataMember]
        public string EngDesc { get; set; }

        [DataMember]
        public string Spec { get; set; }

        [DataMember]
        public int? UnitInId { get; set; }

        [DataMember]
        public decimal? PriceIn { get; set; }

        [DataMember]
        public int? UnitDiagId { get; set; }

        [DataMember]
        public decimal? PriceDiag { get; set; }

        [DataMember]
        public decimal? AddPercent { get; set; }

        [DataMember]
        public short? LsRpType { get; set; }

        [DataMember]
        public decimal? Dosage { get; set; }

        [DataMember]
        public int? UnitTakeId { get; set; }

        [DataMember]
        public int? FrequencyId { get; set; }

        [DataMember]
        public int? UsageId { get; set; }

        [DataMember]
        public int? FeeMzId { get; set; }

        [DataMember]
        public int? FeeZyId { get; set; }

        [DataMember]
        public short? LsGfType { get; set; }

        [DataMember]
        public decimal? GfFixDisc { get; set; }

        [DataMember]
        public bool? OptionPrice { get; set; }

        [DataMember]
        public decimal? LimitTotalMz { get; set; }

        [DataMember]
        public decimal? LimitTotalZy { get; set; }

        [DataMember]
        public int? TypeGfxeId { get; set; }

        [DataMember]
        public bool? IsSpecSum { get; set; }

        [DataMember]
        public bool? IsNew { get; set; }

        [DataMember]
        public bool? IsOnlyForSys { get; set; }

        [DataMember]
        public bool? IsRpForbid { get; set; }

        [DataMember]
        public bool? IsChildAdd { get; set; }

        [DataMember]
        public bool? IsBedFee { get; set; }

        [DataMember]
        public bool? IsOpsAdd { get; set; }

        [DataMember]
        public short? LsfeeTurn { get; set; }

        [DataMember]
        public short? LsAdviceType { get; set; }

        [DataMember]
        public int? LocationId { get; set; }

        [DataMember]
        public int? LisCode { get; set; }

        [DataMember]
        public string CoverPicture { get; set; }

        [DataMember]
        public string MemoPicture { get; set; }

        [DataMember]
        public string Memo { get; set; }

        [DataMember]
        public bool? IsActive { get; set; }

        [DataMember]
        public short? IconIndex { get; set; }

        [DataMember]
        public bool? IsInoculate { get; set; }

        [DataMember]
        public decimal? PriceHighLine { get; set; }

        [DataMember]
        public short? OrderBy { get; set; }

        [DataMember]
        public int? GroupSubId2 { get; set; }

        [DataMember]
        public System.DateTime? LastTime { get; set; }

        [DataMember]
        public decimal? PriceSub { get; set; }

        [DataMember]
        public int? CheckId { get; set; }

        [DataMember]
        public int? NurseId { get; set; }

        [DataMember]
        public int? CureId { get; set; }

        [DataMember]
        public int? DrugId { get; set; }

        [DataMember]
        public int? CopyId { get; set; }

        [DataMember]
        public int? MzUnitTotal { get; set; }

        [DataMember]
        public int? ZyUnitTotal { get; set; }

        [DataMember]
        public bool? IsMtDrug { get; set; }

        [DataMember]
        public string PackageSpec { get; set; }

        [DataMember]
        public bool? IsCitySum { get; set; }

        [DataMember]
        public decimal? YbAvgPrice { get; set; }

        [DataMember]
        public string ProvinceCode { get; set; }

        [DataMember]
        public string OperName { get; set; }
    }
}
