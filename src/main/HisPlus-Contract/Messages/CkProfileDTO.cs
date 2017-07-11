using System;
using System.Runtime.Serialization;
using HisPlus.Infrastructure.Contract.Messages;

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
        public int? ItemId { get; set; }

        [DataMember]
        public int? SourceId { get; set; }

        [DataMember]
        public int? TubeTypeId { get; set; }
    }
}
