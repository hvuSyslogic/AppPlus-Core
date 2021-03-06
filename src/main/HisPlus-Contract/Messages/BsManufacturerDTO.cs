using System;
using System.Runtime.Serialization;
using HisPlus.Infrastructure.Contract.Messages;

namespace HisPlus.Contract.Messages
{
    [Serializable]
    [DataContract]
    public class BsManufacturerDTO : DtoBase<int>
    {
        public BsManufacturerDTO()
        {
        }

        [DataMember]
        public string Code { get; set; }

        [DataMember]
        public string Name { get; set; }

        [DataMember]
        public short? LsKind { get; set; }

        [DataMember]
        public string AreaCode { get; set; }

        [DataMember]
        public string Address { get; set; }

        [DataMember]
        public string WbCode { get; set; }

        [DataMember]
        public string PyCode { get; set; }

        [DataMember]
        public bool IsActive { get; set; }

        [DataMember]
        public short OrderBy { get; set; }

        [DataMember]
        public short IconIndex { get; set; }

        [DataMember]
        public short? LsType { get; set; }
    }
}
