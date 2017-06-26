using System;
using System.Runtime.Serialization;
using AppPlus.Infrastructure.Contract.Messages;

namespace HisPlus.Contract.Messages
{
    [Serializable]
    [DataContract]
    public class RtrjkreportDTO : DtoBase<int>
    {
        public RtrjkreportDTO()
        {
        }

        [DataMember]
        public System.DateTime? Cancelopertime { get; set; }

        [DataMember]
        public int? Iscancel { get; set; }

        [DataMember]
        public System.DateTime? Begintime { get; set; }

        [DataMember]
        public System.DateTime? Endtime { get; set; }

        [DataMember]
        public int? Hospitalid { get; set; }

        [DataMember]
        public string LsOutIn { get; set; }

        [DataMember]
        public int? Bills { get; set; }

        [DataMember]
        public int? Billcancel { get; set; }

        [DataMember]
        public decimal? AmountSum { get; set; }

        [DataMember]
        public decimal? Amount { get; set; }

        [DataMember]
        public decimal? AmountCancel { get; set; }

        [DataMember]
        public decimal? Insurance { get; set; }

        [DataMember]
        public decimal? AmountPay { get; set; }

        [DataMember]
        public decimal? AmountYf { get; set; }

        [DataMember]
        public System.DateTime? SignTime { get; set; }

        [DataMember]
        public int? SignOperId { get; set; }

        [DataMember]
        public string Memo { get; set; }
    }
}
