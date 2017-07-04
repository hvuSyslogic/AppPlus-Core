using System;
using System.Runtime.Serialization;
using AppPlus.Infrastructure.Contract.Messages;

namespace HisPlus.Contract.Messages
{
    [Serializable]
    [DataContract]
    public class OuInvoicePayDTO : DtoBase<int>
    {
        public OuInvoicePayDTO()
        {
        }

        [DataMember]
        public int InvoId { get; set; }

        [DataMember]
        public int PaywayId { get; set; }

        [DataMember]
        public decimal Amount { get; set; }

        [DataMember]
        public int? CancelPaywayId { get; set; }
    }
}
