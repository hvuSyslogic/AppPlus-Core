using System;
using System.Runtime.Serialization;
using HisPlus.Infrastructure.Contract.Messages;

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
    }
}
