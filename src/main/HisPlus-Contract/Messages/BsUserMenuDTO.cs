using System;
using System.Runtime.Serialization;
using HisPlus.Infrastructure.Contract.Messages;

namespace HisPlus.Contract.Messages
{
    [Serializable]
    [DataContract]
    public class BsUserMenuDTO : DtoBase<int>
    {
        public BsUserMenuDTO()
        {
        }

        [DataMember]
        public int OperId { get; set; }

        [DataMember]
        public int? MenuId { get; set; }

        [DataMember]
        public int? OrderBy { get; set; }

        [DataMember]
        public short IconIndex { get; set; }
    }
}
