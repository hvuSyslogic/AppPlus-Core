using System;
using System.Runtime.Serialization;
using AppPlus.Infrastructure.Contract.Messages;

namespace HisPlus.Contract.Messages
{
    [Serializable]
    [DataContract]
    public class GblCatalogJoinDTO : DtoBase<int>
    {
        public GblCatalogJoinDTO()
        {
        }

        [DataMember]
        public int CatalogId1 { get; set; }

        [DataMember]
        public string XmlField1 { get; set; }

        [DataMember]
        public int CatalogId2 { get; set; }

        [DataMember]
        public string XmlField2 { get; set; }
    }
}
