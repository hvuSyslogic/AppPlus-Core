using System;
using System.Runtime.Serialization;
using AppPlus.Infrastructure.Contract.Messages;

namespace HisPlus.Contract.Messages
{
    [Serializable]
    [DataContract]
    public class BsPatMenuIndexDTO : DtoBase<int>
    {
        public BsPatMenuIndexDTO()
        {
        }

        [DataMember]
        public int PatId { get; set; }

        [DataMember]
        public int PatMenuId { get; set; }

        [DataMember]
        public string ParentId { get; set; }

        [DataMember]
        public int RecordId { get; set; }

        [DataMember]
        public string Tips { get; set; }
    }
}
