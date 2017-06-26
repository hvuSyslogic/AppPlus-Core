using System;
using System.Runtime.Serialization;
using AppPlus.Infrastructure.Contract.Messages;

namespace HisPlus.Contract.Messages
{
    [Serializable]
    [DataContract]
    public class GblEmrFileDTO : DtoBase<int>
    {
        public GblEmrFileDTO()
        {
        }

        [DataMember]
        public int? LocationId { get; set; }

        [DataMember]
        public int CatalogId { get; set; }

        [DataMember]
        public string XsdFile { get; set; }
    }
}
