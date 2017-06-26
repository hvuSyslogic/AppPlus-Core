using System;
using System.Runtime.Serialization;
using AppPlus.Infrastructure.Contract.Messages;

namespace HisPlus.Contract.Messages
{
    [Serializable]
    [DataContract]
    public class EquipmentDTO : DtoBase<int>
    {
        public EquipmentDTO()
        {
        }

        [DataMember]
        public string Code { get; set; }

        [DataMember]
        public string Name { get; set; }

        [DataMember]
        public string PyCode { get; set; }

        [DataMember]
        public string WbCode { get; set; }

        [DataMember]
        public short OrderBy { get; set; }

        [DataMember]
        public string Spec { get; set; }

        [DataMember]
        public string EqType { get; set; }

        [DataMember]
        public string SeriesNo { get; set; }

        [DataMember]
        public string Brand { get; set; }

        [DataMember]
        public int? CountryId { get; set; }

        [DataMember]
        public int? ManuId { get; set; }

        [DataMember]
        public int? CompId { get; set; }

        [DataMember]
        public string RepairBy { get; set; }

        [DataMember]
        public System.DateTime? BuyDate { get; set; }

        [DataMember]
        public System.DateTime? StartDate { get; set; }

        [DataMember]
        public int? LimitYears { get; set; }

        [DataMember]
        public int? MnrgLocId { get; set; }

        [DataMember]
        public int? UseLocId { get; set; }

        [DataMember]
        public short? LsQuaClass { get; set; }

        [DataMember]
        public short? LsEqClass { get; set; }

        [DataMember]
        public string InActiveReason { get; set; }

        [DataMember]
        public System.DateTime? InActiveTime { get; set; }

        [DataMember]
        public int? InActiveOperId { get; set; }

        [DataMember]
        public string LotNo { get; set; }

        [DataMember]
        public string StoreIn { get; set; }

        [DataMember]
        public string Manager { get; set; }

        [DataMember]
        public short? LsEqStatus { get; set; }

        [DataMember]
        public decimal? Price { get; set; }

        [DataMember]
        public int? HowMany { get; set; }

        [DataMember]
        public decimal? Amount { get; set; }

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
        public string Attachment { get; set; }

        [DataMember]
        public string UseArea { get; set; }

        [DataMember]
        public string UseMemo { get; set; }

        [DataMember]
        public string Memo { get; set; }

        [DataMember]
        public string F1 { get; set; }

        [DataMember]
        public string F2 { get; set; }

        [DataMember]
        public string F3 { get; set; }

        [DataMember]
        public string F4 { get; set; }

        [DataMember]
        public short IconIndex { get; set; }

        [DataMember]
        public short LsEqType { get; set; }

        [DataMember]
        public int? GroupSubId { get; set; }

        [DataMember]
        public int? CopyId { get; set; }

        [DataMember]
        public string VoucherNo { get; set; }

        [DataMember]
        public string ProduceArea { get; set; }
    }
}
