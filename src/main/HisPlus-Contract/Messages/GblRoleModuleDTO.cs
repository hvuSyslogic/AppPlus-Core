using System;
using System.Runtime.Serialization;
using AppPlus.Infrastructure.Contract.Messages;

namespace HisPlus.Contract.Messages
{
    [Serializable]
    [DataContract]
    public class GblRoleModuleDTO : DtoBase<int>
    {
        public GblRoleModuleDTO()
        {
        }

        [DataMember]
        public int RoleId { get; set; }

        [DataMember]
        public int ModuleId { get; set; }

        [DataMember]
        public short IconIndex { get; set; }
    }
}
