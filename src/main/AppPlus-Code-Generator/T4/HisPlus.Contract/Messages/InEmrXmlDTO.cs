using System;
using System.Runtime.Serialization;
using AppPlus.Infrastructure.Contract.Messages;

namespace HisPlus.Contract.Messages
{
    [Serializable]
    [DataContract]
    public class InEmrXmlDTO : DtoBase<int>
    {
        public InEmrXmlDTO()
        {
        }

        [DataMember]
        public int HospId { get; set; }

        [DataMember]
        public System.DateTime? OperTime { get; set; }

        [DataMember]
        public int CatalogId { get; set; }

        [DataMember]
        public string XmlField { get; set; }

        [DataMember]
        public string XmlValue { get; set; }

        [DataMember]
        public int? InEmrId { get; set; }
    }
}
