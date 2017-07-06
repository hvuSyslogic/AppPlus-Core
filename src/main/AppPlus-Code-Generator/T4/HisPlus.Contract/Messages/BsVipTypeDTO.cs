using System;
using System.Runtime.Serialization;
using AppPlus.Infrastructure.Contract.Messages;

namespace HisPlus.Contract.Messages
{
    [Serializable]
    [DataContract]
    public class BsVipTypeDTO : DtoBase<int>
    {
        public BsVipTypeDTO()
        {
        }

        [DataMember]
        public string Name { get; set; }

        [DataMember]
        public int? OrderBy { get; set; }

        [DataMember]
        public bool? IsActive { get; set; }
    }
}
