using System;
using System.Runtime.Serialization;
using AppPlus.Infrastructure.Contract.Messages;

namespace HisPlus.Contract.Messages
{
    [Serializable]
    [DataContract]
    public class HuVoucherDtlDTO : DtoBase<int>
    {
        public HuVoucherDtlDTO()
        {
        }

        [DataMember]
        public int? VoucherId { get; set; }

        [DataMember]
        public int BillId { get; set; }

        [DataMember]
        public decimal? Amount { get; set; }

        [DataMember]
        public decimal? HasPay { get; set; }

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
