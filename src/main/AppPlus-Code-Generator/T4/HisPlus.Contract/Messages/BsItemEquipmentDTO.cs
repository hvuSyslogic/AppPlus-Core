using System;
using System.Runtime.Serialization;
using AppPlus.Infrastructure.Contract.Messages;

namespace HisPlus.Contract.Messages
{
    [Serializable]
    [DataContract]
    public class BsItemEquipmentDTO : DtoBase<int>
    {
        public BsItemEquipmentDTO()
        {
        }

        [DataMember]
        public int ItemId { get; set; }

        [DataMember]
        public short? LsEqType { get; set; }

        [DataMember]
        public int? EqTypeId { get; set; }

        [DataMember]
        public string EqType { get; set; }

        [DataMember]
        public string SeriesNo { get; set; }

        [DataMember]
        public string Brand { get; set; }

        [DataMember]
        public int? CountryId { get; set; }

        [DataMember]
        public string RepairBy { get; set; }

        [DataMember]
        public int? LimitYears { get; set; }

        [DataMember]
        public short? LsQuaClass { get; set; }

        [DataMember]
        public short? LsEqClass { get; set; }

        [DataMember]
        public decimal? MonthDisc { get; set; }

        [DataMember]
        public short? LsMoneyFrom { get; set; }

        [DataMember]
        public decimal? MoneyGiven { get; set; }

        [DataMember]
        public decimal? MoneySelf { get; set; }

        [DataMember]
        public decimal? UnderLine { get; set; }

        [DataMember]
        public int? UnitId { get; set; }

        [DataMember]
        public int? CostPercent { get; set; }

        [DataMember]
        public decimal? AlarmLine { get; set; }

        [DataMember]
        public bool? IsCalProfit { get; set; }

        [DataMember]
        public string UseArea { get; set; }

        [DataMember]
        public string UseMemo { get; set; }

        [DataMember]
        public string F1 { get; set; }

        [DataMember]
        public string F2 { get; set; }

        [DataMember]
        public string F3 { get; set; }

        [DataMember]
        public string F4 { get; set; }

        [DataMember]
        public short? IconIndex { get; set; }
    }
}
