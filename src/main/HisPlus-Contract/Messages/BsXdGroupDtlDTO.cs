using System;
using System.Runtime.Serialization;
using HisPlus.Infrastructure.Contract.Messages;

namespace HisPlus.Contract.Messages
{
    [Serializable]
    [DataContract]
    public class BsXdGroupDtlDTO : DtoBase<int>
    {
        public BsXdGroupDtlDTO()
        {
        }

        [DataMember]
        public int GroupId { get; set; }

        [DataMember]
        public int XdRpId { get; set; }

        [DataMember]
        public short OrderBy { get; set; }

        [DataMember]
        public bool IsActive { get; set; }

        [DataMember]
        public short LsOpenType { get; set; }

        [DataMember]
        public int OperId { get; set; }

        [DataMember]
        public System.DateTime OperTime { get; set; }

        [DataMember]
        public int LocationId { get; set; }

        [DataMember]
        public short IconIndex { get; set; }
    }
}
