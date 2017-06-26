using System;
using System.Runtime.Serialization;
using AppPlus.Infrastructure.Contract.Messages;

namespace HisPlus.Contract.Messages
{
    [Serializable]
    [DataContract]
    public class HuCheckSumDTO : DtoBase<int>
    {
        public HuCheckSumDTO()
        {
        }

        [DataMember]
        public int BillId { get; set; }

        [DataMember]
        public string SumFor { get; set; }

        [DataMember]
        public decimal BuyIn { get; set; }

        [DataMember]
        public decimal BackIn { get; set; }

        [DataMember]
        public decimal PyIn { get; set; }

        [DataMember]
        public decimal OtherIn { get; set; }

        [DataMember]
        public decimal DeptOut { get; set; }

        [DataMember]
        public decimal SaleOut { get; set; }

        [DataMember]
        public decimal BackOut { get; set; }

        [DataMember]
        public decimal PkOut { get; set; }

        [DataMember]
        public decimal LoseOut { get; set; }

        [DataMember]
        public decimal AdjustAmouUp { get; set; }

        [DataMember]
        public decimal AdjustAmouDn { get; set; }

        [DataMember]
        public decimal CheckAmou { get; set; }

        [DataMember]
        public decimal BalanceAmou { get; set; }

        [DataMember]
        public decimal TotalPrice { get; set; }

        [DataMember]
        public string F1 { get; set; }

        [DataMember]
        public string F2 { get; set; }

        [DataMember]
        public string F3 { get; set; }

        [DataMember]
        public string F4 { get; set; }
    }
}
