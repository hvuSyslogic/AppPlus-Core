using System;
using System.Runtime.Serialization;
using AppPlus.Infrastructure.Contract.Messages;

namespace HisPlus.Contract.Messages
{
    [Serializable]
    [DataContract]
    public class OuDocSpanSubDTO : DtoBase<int>
    {
        public OuDocSpanSubDTO()
        {
        }

        [DataMember]
        public int? Weekplanid { get; set; }

        [DataMember]
        public int? Spanlimitnum { get; set; }

        [DataMember]
        public int? Sublimitnum { get; set; }

        [DataMember]
        public int? Timespansubid { get; set; }
    }
}
