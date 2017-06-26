using System;
using System.Runtime.Serialization;
using AppPlus.Infrastructure.Contract.Messages;

namespace HisPlus.Contract.Messages
{
    [Serializable]
    [DataContract]
    public class InDepositDTO : DtoBase<int>
    {
        public InDepositDTO()
        {
        }

        [DataMember]
        public string BillNo { get; set; }

        [DataMember]
        public int HospId { get; set; }

        [DataMember]
        public System.DateTime OperTime { get; set; }

        [DataMember]
        public int OperId { get; set; }

        [DataMember]
        public decimal Amount { get; set; }

        [DataMember]
        public decimal Remain { get; set; }

        [DataMember]
        public bool IsFirst { get; set; }

        [DataMember]
        public string Remark { get; set; }

        [DataMember]
        public bool IsCancel { get; set; }

        [DataMember]
        public short? LsCancelType { get; set; }

        [DataMember]
        public System.DateTime? CancelOperTime { get; set; }

        [DataMember]
        public int? CancelOperId { get; set; }

        [DataMember]
        public int? InvoId { get; set; }

        [DataMember]
        public string F1 { get; set; }

        [DataMember]
        public string F2 { get; set; }

        [DataMember]
        public string F3 { get; set; }

        [DataMember]
        public string F4 { get; set; }

        [DataMember]
        public int? HospitalId { get; set; }

        [DataMember]
        public System.DateTime? CheckTime { get; set; }

        [DataMember]
        public System.DateTime? CancelCheckTime { get; set; }
    }
}
