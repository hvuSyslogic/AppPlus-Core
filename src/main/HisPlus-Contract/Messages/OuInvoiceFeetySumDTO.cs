using System;
using System.Runtime.Serialization;
using HisPlus.Infrastructure.Contract.Messages;

namespace HisPlus.Contract.Messages
{
    [Serializable]
    [DataContract]
    public class OuInvoiceFeetySumDTO : DtoBase<int>
    {
        public OuInvoiceFeetySumDTO()
        {
        }

        [DataMember]
        public int InvoId { get; set; }

        [DataMember]
        public int FeeId { get; set; }

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
    }
}
