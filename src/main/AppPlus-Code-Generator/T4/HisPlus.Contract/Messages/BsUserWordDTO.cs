using System;
using System.Runtime.Serialization;
using AppPlus.Infrastructure.Contract.Messages;

namespace HisPlus.Contract.Messages
{
    [Serializable]
    [DataContract]
    public class BsUserWordDTO : DtoBase<int>
    {
        public BsUserWordDTO()
        {
        }

        [DataMember]
        public int OperId { get; set; }

        [DataMember]
        public string KeyType { get; set; }

        [DataMember]
        public string Content { get; set; }

        [DataMember]
        public short? IconIndex { get; set; }
    }
}
