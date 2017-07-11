using System;
using System.Runtime.Serialization;
using HisPlus.Infrastructure.Contract.Messages;

namespace HisPlus.Contract.Messages
{
    [Serializable]
    [DataContract]
    public class BsUserModuleDTO : DtoBase<int>
    {
        public BsUserModuleDTO()
        {
        }

        [DataMember]
        public int OperId { get; set; }

        [DataMember]
        public int ModuleId { get; set; }

        [DataMember]
        public short IconIndex { get; set; }
    }
}
