using System;
using System.Runtime.Serialization;
using HisPlus.Infrastructure.Contract.Messages;

namespace HisPlus.Contract.Messages
{
    [Serializable]
    [DataContract]
    public class BsUserWindowDTO : DtoBase<int>
    {
        public BsUserWindowDTO()
        {
        }

        [DataMember]
        public int OperId { get; set; }

        [DataMember]
        public int MenuId { get; set; }

        [DataMember]
        public string Name { get; set; }

        [DataMember]
        public string Caption { get; set; }
    }
}
