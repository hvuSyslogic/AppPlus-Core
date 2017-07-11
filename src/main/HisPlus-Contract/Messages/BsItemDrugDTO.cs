using System;
using System.Runtime.Serialization;
using HisPlus.Infrastructure.Contract.Messages;

namespace HisPlus.Contract.Messages
{
    [Serializable]
    [DataContract]
    public class BsItemDrugDTO : DtoBase<int>
    {
        public BsItemDrugDTO()
        {
        }

        [DataMember]
        public int ItemId { get; set; }

        [DataMember]
        public string ChemName { get; set; }

        [DataMember]
        public bool? IsRecipe { get; set; }

        [DataMember]
        public bool? IsPoison { get; set; }

        [DataMember]
        public bool? IsMental { get; set; }

        [DataMember]
        public bool? IsExpen { get; set; }

        [DataMember]
        public bool? IsSelf { get; set; }

        [DataMember]
        public int? ProAreaId { get; set; }

        [DataMember]
        public int? AheadAlert { get; set; }

        [DataMember]
        public decimal? UnderLineKc { get; set; }

        [DataMember]
        public decimal? UperLineKc { get; set; }

        [DataMember]
        public decimal? NormalLineKc { get; set; }

        [DataMember]
        public int? FormId { get; set; }

        [DataMember]
        public int? ManuId { get; set; }

        [DataMember]
        public string PassNo { get; set; }

        [DataMember]
        public string AreaKc { get; set; }

        [DataMember]
        public short? LsImport { get; set; }

        [DataMember]
        public bool? IsInject { get; set; }

        [DataMember]
        public bool? IsSpecial { get; set; }

        [DataMember]
        public int? HouseId { get; set; }

        [DataMember]
        public int? RoomIdOut { get; set; }

        [DataMember]
        public int? RoomIdIn { get; set; }

        [DataMember]
        public int? UnitKc { get; set; }

        [DataMember]
        public decimal? RetailPriceKc { get; set; }

        [DataMember]
        public decimal? StockPriceKc { get; set; }

        [DataMember]
        public bool? IsBid { get; set; }

        [DataMember]
        public bool? IsLocDrug { get; set; }

        [DataMember]
        public int? CompId { get; set; }

        [DataMember]
        public bool? IsBatch { get; set; }

        [DataMember]
        public bool? IsSave { get; set; }

        [DataMember]
        public short? IconIndex { get; set; }

        [DataMember]
        public int? DrugId { get; set; }

        [DataMember]
        public string BuyInCode { get; set; }

        [DataMember]
        public bool? IsSecMental { get; set; }

        [DataMember]
        public bool? IsSkin { get; set; }

        [DataMember]
        public bool? IsAntiBacterial { get; set; }

        [DataMember]
        public bool? IsHighDanger { get; set; }

        [DataMember]
        public bool? IsDanger { get; set; }

        [DataMember]
        public bool? IsVaccine { get; set; }

        [DataMember]
        public bool? IsTestReport { get; set; }

        [DataMember]
        public bool? IsAnaes { get; set; }

        [DataMember]
        public bool? IsMeetingUse { get; set; }

        [DataMember]
        public string RegNo { get; set; }

        [DataMember]
        public string ImpotTestBy { get; set; }

        [DataMember]
        public string TestReportNo { get; set; }

        [DataMember]
        public bool? IsParity { get; set; }

        [DataMember]
        public string DddMinValue { get; set; }

        [DataMember]
        public string DddValue { get; set; }

        [DataMember]
        public string DrugsTypes { get; set; }

        [DataMember]
        public bool? NotXZjDrug { get; set; }

        [DataMember]
        public bool? XZjDrug { get; set; }

        [DataMember]
        public bool? TSjDrug { get; set; }

        [DataMember]
        public bool? IsAz { get; set; }

        [DataMember]
        public bool? IsJh { get; set; }
    }
}
