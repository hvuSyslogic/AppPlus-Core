using System;
using System.Runtime.Serialization;
using AppPlus.Infrastructure.Contract.Messages;

namespace HisPlus.Contract.Messages
{
    [Serializable]
    [DataContract]
    public class BsUserEmrTemplateDTO : DtoBase<int>
    {
        public BsUserEmrTemplateDTO()
        {
        }

        [DataMember]
        public int OperId { get; set; }

        [DataMember]
        public int CatalogId { get; set; }

        [DataMember]
        public string Name { get; set; }

        [DataMember]
        public string TemplateFile { get; set; }

        [DataMember]
        public bool IsDefault { get; set; }

        [DataMember]
        public short OrderBy { get; set; }

        [DataMember]
        public string F1 { get; set; }

        [DataMember]
        public string F2 { get; set; }

        [DataMember]
        public string F3 { get; set; }

        [DataMember]
        public string F4 { get; set; }

        [DataMember]
        public short IconIndex { get; set; }

        [DataMember]
        public short? LsOpenType { get; set; }

        [DataMember]
        public System.DateTime? OperTime { get; set; }

        [DataMember]
        public int? LocationId { get; set; }

        [DataMember]
        public bool? IsActive { get; set; }
    }
}
