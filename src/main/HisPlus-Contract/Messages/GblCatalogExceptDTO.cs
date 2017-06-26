using System;
using System.Runtime.Serialization;
using AppPlus.Infrastructure.Contract.Messages;

namespace HisPlus.Contract.Messages
{
    [Serializable]
    [DataContract]
    public class GblCatalogExceptDTO : DtoBase<int>
    {
        public GblCatalogExceptDTO()
        {
        }

        [DataMember]
        public int CatalogId { get; set; }

        [DataMember]
        public string XmlField { get; set; }

        [DataMember]
        public bool? IsHide { get; set; }

        [DataMember]
        public string DefaultValue { get; set; }

        [DataMember]
        public bool? IsBaby { get; set; }

        [DataMember]
        public bool? IsWomen { get; set; }

        [DataMember]
        public bool? IsMen { get; set; }

        [DataMember]
        public bool? IsOlder { get; set; }

        [DataMember]
        public string Memo { get; set; }

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
