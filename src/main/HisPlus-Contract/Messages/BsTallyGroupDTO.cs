using System;
using System.Runtime.Serialization;
using HisPlus.Infrastructure.Contract.Messages;

namespace HisPlus.Contract.Messages
{
    [Serializable]
    [DataContract]
    public class BsTallyGroupDTO : DtoBase<int>
    {
        public BsTallyGroupDTO()
        {
        }

        [DataMember]
        public string Code { get; set; }

        [DataMember]
        public string Name { get; set; }

        [DataMember]
        public bool IsGf { get; set; }

        [DataMember]
        public bool IsYb { get; set; }

        [DataMember]
        public string YbHospNo { get; set; }

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
        public string ZyClassName { get; set; }

        [DataMember]
        public string MzClassName { get; set; }

        [DataMember]
        public short? Lsinout { get; set; }
    }
}
