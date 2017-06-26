using System;
using System.Runtime.Serialization;
using AppPlus.Infrastructure.Contract.Messages;

namespace HisPlus.Contract.Messages
{
    [Serializable]
    [DataContract]
    public class InInvoiceDtlCancelDTO : DtoBase<int>
    {
        public InInvoiceDtlCancelDTO()
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
        public string F1 { get; set; }

        [DataMember]
        public string F2 { get; set; }

        [DataMember]
        public string F3 { get; set; }

        [DataMember]
        public string F4 { get; set; }

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
        public int? MainDoctorId { get; set; }

        [DataMember]
        public int? DocLocId { get; set; }

        [DataMember]
        public int? ExecDoctorId { get; set; }
    }
}
