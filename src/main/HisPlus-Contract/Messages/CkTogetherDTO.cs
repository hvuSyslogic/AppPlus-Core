using System;
using System.Runtime.Serialization;
using AppPlus.Infrastructure.Contract.Messages;

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

        [DataMember]
        public string F1 { get; set; }

        [DataMember]
        public string F2 { get; set; }

        [DataMember]
        public string F3 { get; set; }

        [DataMember]
        public string F4 { get; set; }
    }
}
