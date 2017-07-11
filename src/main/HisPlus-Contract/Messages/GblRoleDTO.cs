using System;
using System.Runtime.Serialization;
using HisPlus.Infrastructure.Contract.Messages;

namespace HisPlus.Contract.Messages
{
    [Serializable]
    [DataContract]
    public class GblRoleDTO : DtoBase<int>
    {
        public GblRoleDTO()
        {
        }

        [DataMember]
        public string Code { get; set; }

        [DataMember]
        public string Name { get; set; }

        [DataMember]
        public bool IsActive { get; set; }

        [DataMember]
        public short OrderBy { get; set; }

        [DataMember]
        public short IconIndex { get; set; }

        [DataMember]
        public string GroupName { get; set; }
    }
}
