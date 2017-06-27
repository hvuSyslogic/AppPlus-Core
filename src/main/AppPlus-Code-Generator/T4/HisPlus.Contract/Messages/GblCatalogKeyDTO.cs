using System;
using System.Runtime.Serialization;
using AppPlus.Infrastructure.Contract.Messages;

namespace HisPlus.Contract.Messages
{
    [Serializable]
    [DataContract]
    public class GblCatalogKeyDTO : DtoBase<int>
    {
        public GblCatalogKeyDTO()
        {
        }

        [DataMember]
        public int CatalogId { get; set; }

        [DataMember]
        public string XmlField { get; set; }

        [DataMember]
        public string KeyFile { get; set; }

        [DataMember]
        public string TmpWord { get; set; }

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