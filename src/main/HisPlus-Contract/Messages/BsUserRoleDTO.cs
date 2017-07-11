using System;
using System.Runtime.Serialization;
using HisPlus.Infrastructure.Contract.Messages;

namespace HisPlus.Contract.Messages
{
    [Serializable]
    [DataContract]
    public class BsUserRoleDTO : DtoBase<int>
    {
        public BsUserRoleDTO()
        {
        }

        [DataMember]
        public int OperId { get; set; }

        [DataMember]
        public int RoleId { get; set; }

        [DataMember]
        public short IconIndex { get; set; }
    }
}
