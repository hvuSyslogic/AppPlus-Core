using System;
using System.Runtime.Serialization;
using AppPlus.Infrastructure.Contract.Messages;

namespace HisPlus.Contract.Messages
{
    [Serializable]
    [DataContract]
    public class BaseTableRoleDTO : DtoBase<int>
    {
        public BaseTableRoleDTO()
        {
        }

        [DataMember]
        public int? BaseTableId { get; set; }

        [DataMember]
        public int? RoleId { get; set; }
    }
}
