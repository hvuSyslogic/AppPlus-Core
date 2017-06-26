using System;
using System.Runtime.Serialization;
using AppPlus.Infrastructure.Contract.Messages;

namespace HisPlus.Contract.Messages
{
    [Serializable]
    [DataContract]
    public class CkProfileDTO : DtoBase<int>
    {
        public CkProfileDTO()
        {
        }

        [DataMember]
        public int ProfileId { get; set; }

        [DataMember]
        public int TestId { get; set; }

        [DataMember]
        public string F1 { get; set; }

        [DataMember]
        public string F2 { get; set; }

        [DataMember]
        public string F3 { get; set; }

        [DataMember]
        public string F4 { get; set; }

        [DataMember]
        public int? ItemId { get; set; }
    }
}
