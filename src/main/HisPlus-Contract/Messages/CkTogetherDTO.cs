using System;
using System.Runtime.Serialization;
using HisPlus.Infrastructure.Contract.Messages;

namespace HisPlus.Contract.Messages
{
    [Serializable]
    [DataContract]
    public class CkTogetherDTO : DtoBase<int>
    {
        public CkTogetherDTO()
        {
        }

        [DataMember]
        public int TestId1 { get; set; }

        [DataMember]
        public int? TestId2 { get; set; }
    }
}
