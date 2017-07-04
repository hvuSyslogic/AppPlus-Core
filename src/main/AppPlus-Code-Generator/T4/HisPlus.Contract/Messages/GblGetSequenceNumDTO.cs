using System;
using System.Runtime.Serialization;
using AppPlus.Infrastructure.Contract.Messages;

namespace HisPlus.Contract.Messages
{
    [Serializable]
    [DataContract]
    public class GblGetSequenceNumDTO : DtoBase<int>
    {
        public GblGetSequenceNumDTO()
        {
        }

        [DataMember]
        public long NextSequenceNum { get; set; }

        [DataMember]
        public bool IsDayBegin { get; set; }

        [DataMember]
        public string GetdateStr { get; private set; }

        [DataMember]
        public string NextSequenceStr { get; private set; }
    }
}
