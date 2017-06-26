using System;
using System.Runtime.Serialization;
using AppPlus.Infrastructure.Contract.Messages;

namespace HisPlus.Contract.Messages
{
    [Serializable]
    [DataContract]
    public class CkBdBankDTO : DtoBase<int>
    {
        public CkBdBankDTO()
        {
        }

        [DataMember]
        public string SerialNo { get; set; }

        [DataMember]
        public short BloodTypeId { get; set; }

        [DataMember]
        public string BloodGroup { get; set; }

        [DataMember]
        public string Rhd { get; set; }

        [DataMember]
        public System.DateTime RecieveDate { get; set; }

        [DataMember]
        public int RecieveOperId { get; set; }

        [DataMember]
        public short LsSource { get; set; }

        [DataMember]
        public string Account { get; set; }

        [DataMember]
        public System.DateTime? ExpireDate { get; set; }

        [DataMember]
        public string OfferMan { get; set; }

        [DataMember]
        public System.DateTime? CollectDate { get; set; }

        [DataMember]
        public string CollectMan { get; set; }

        [DataMember]
        public decimal? Vollume { get; set; }

        [DataMember]
        public decimal? Price { get; set; }

        [DataMember]
        public short LsStatus { get; set; }

        [DataMember]
        public System.DateTime? BackDate { get; set; }

        [DataMember]
        public int? BackOperId { get; set; }

        [DataMember]
        public string BackMemo { get; set; }

        [DataMember]
        public string F1 { get; set; }

        [DataMember]
        public string F2 { get; set; }

        [DataMember]
        public string F3 { get; set; }

        [DataMember]
        public string F4 { get; set; }

        [DataMember]
        public string Unit { get; set; }

        [DataMember]
        public string DiscardReason { get; set; }

        [DataMember]
        public System.DateTime? DiscardTime { get; set; }

        [DataMember]
        public int? DiscardOperId { get; set; }
    }
}
