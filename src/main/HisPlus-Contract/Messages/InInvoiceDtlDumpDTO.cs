using System;
using System.Runtime.Serialization;
using HisPlus.Infrastructure.Contract.Messages;

namespace HisPlus.Contract.Messages
{
    [Serializable]
    [DataContract]
    public class InInvoiceDtlDumpDTO : DtoBase<int>
    {
        public InInvoiceDtlDumpDTO()
        {
        }

        [DataMember]
        public int HospId { get; set; }

        [DataMember]
        public int ItemId { get; set; }

        [DataMember]
        public System.DateTime RegOperTime { get; set; }

        [DataMember]
        public int RegOperId { get; set; }

        [DataMember]
        public int LocationId { get; set; }

        [DataMember]
        public int AdviceId { get; set; }

        [DataMember]
        public short LsMarkType { get; set; }

        [DataMember]
        public decimal Totality { get; set; }

        [DataMember]
        public decimal PriceIn { get; set; }

        [DataMember]
        public int UnitId { get; set; }

        [DataMember]
        public bool IsPay { get; set; }

        [DataMember]
        public decimal DiscIn { get; set; }

        [DataMember]
        public decimal DiscSelf { get; set; }

        [DataMember]
        public decimal Amount { get; set; }

        [DataMember]
        public decimal AmountFact { get; set; }

        [DataMember]
        public decimal AmountSelf { get; set; }

        [DataMember]
        public decimal AmountTally { get; set; }

        [DataMember]
        public decimal AmountPay { get; set; }

        [DataMember]
        public int? InvoId { get; set; }

        [DataMember]
        public short LsPerform { get; set; }

        [DataMember]
        public bool IsModiDisc { get; set; }

        [DataMember]
        public int? LimitGroupId { get; set; }

        [DataMember]
        public decimal? LimitFee { get; set; }

        [DataMember]
        public int DoctorId { get; set; }

        [DataMember]
        public int ExecOperId { get; set; }

        [DataMember]
        public int ExecLocId { get; set; }

        [DataMember]
        public int InvItemId { get; set; }

        [DataMember]
        public int FeeId { get; set; }

        [DataMember]
        public int? FeeHsId { get; set; }

        [DataMember]
        public int? LsReportType { get; set; }

        [DataMember]
        public string Memo { get; set; }

        [DataMember]
        public System.DateTime OperTime { get; set; }

        [DataMember]
        public int OperId { get; set; }

        [DataMember]
        public bool IsCancel { get; set; }

        [DataMember]
        public int? CancelId { get; set; }

        [DataMember]
        public bool IsManual { get; set; }

        [DataMember]
        public string HostName { get; set; }

        [DataMember]
        public int? ExecuteId { get; set; }

        [DataMember]
        public string RegDate { get; set; }

        [DataMember]
        public int? GroupItemId { get; set; }

        [DataMember]
        public int? XdRpId { get; set; }

        [DataMember]
        public string AdviceName { get; set; }

        [DataMember]
        public int? AuthDtlId { get; set; }

        [DataMember]
        public int? CheckOperId { get; set; }

        [DataMember]
        public string ReservedField { get; set; }

        [DataMember]
        public string ReservedField2 { get; set; }

        [DataMember]
        public int? LsStatus { get; set; }

        [DataMember]
        public int? GroupNum { get; set; }

        [DataMember]
        public decimal? Dosage { get; set; }

        [DataMember]
        public int? UnitTakeId { get; set; }

        [DataMember]
        public int? FrequencyId { get; set; }

        [DataMember]
        public System.DateTime? CheckTime { get; set; }

        [DataMember]
        public int? CheckOperId1 { get; set; }

        [DataMember]
        public System.DateTime? DeleteTime { get; set; }

        [DataMember]
        public int? DeleteOperId { get; set; }

        [DataMember]
        public int? AuthDtlId1 { get; set; }

        [DataMember]
        public decimal? PriceIn1 { get; set; }

        [DataMember]
        public decimal? PriceIn2 { get; set; }

        [DataMember]
        public int? LsPriceState { get; set; }

        [DataMember]
        public string Urgent { get; set; }

        [DataMember]
        public string Usagememo { get; set; }

        [DataMember]
        public int? Usageid { get; set; }

        [DataMember]
        public int? Formid { get; set; }
    }
}
