using System;
using System.Runtime.Serialization;
using AppPlus.Infrastructure.Contract.Messages;

namespace HisPlus.Contract.Messages
{
    [Serializable]
    [DataContract]
    public class GblEmrBranchDTO : DtoBase<int>
    {
        public GblEmrBranchDTO()
        {
        }

        [DataMember]
        public int? BranchId { get; set; }

        [DataMember]
        public int CatalogId { get; set; }

        [DataMember]
        public string XsdFile { get; set; }

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