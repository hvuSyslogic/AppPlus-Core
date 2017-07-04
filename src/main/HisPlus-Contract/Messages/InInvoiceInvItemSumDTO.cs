using System;
using System.Runtime.Serialization;
using AppPlus.Infrastructure.Contract.Messages;

namespace HisPlus.Contract.Messages
{
    [Serializable]
    [DataContract]
    public class InInvoiceInvItemSumDTO : DtoBase<int>
    {
        public InInvoiceInvItemSumDTO()
        {
        }

        [DataMember]
        public int InvoId { get; set; }

        [DataMember]
        public int InvItemId { get; set; }

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
        public decimal? MzAmount { get; set; }

        [DataMember]
        public decimal? Insurance { get; set; }
    }
}
