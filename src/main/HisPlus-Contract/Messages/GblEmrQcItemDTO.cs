using System;
using System.Runtime.Serialization;
using HisPlus.Infrastructure.Contract.Messages;

namespace HisPlus.Contract.Messages
{
    [Serializable]
    [DataContract]
    public class GblEmrQcItemDTO : DtoBase<int>
    {
        public GblEmrQcItemDTO()
        {
        }

        [DataMember]
        public int GroupId { get; set; }

        [DataMember]
        public string Code { get; set; }

        [DataMember]
        public string Name { get; set; }

        [DataMember]
        public string Standard { get; set; }

        [DataMember]
        public string PyCode { get; set; }

        [DataMember]
        public string WbCode { get; set; }

        [DataMember]
        public short OrderBy { get; set; }

        [DataMember]
        public bool IsActive { get; set; }

        [DataMember]
        public short IconIndex { get; set; }

        [DataMember]
        public short? FullPoint { get; set; }

        [DataMember]
        public short? FailPoint { get; set; }

        [DataMember]
        public short? LsImportant { get; set; }
    }
}
