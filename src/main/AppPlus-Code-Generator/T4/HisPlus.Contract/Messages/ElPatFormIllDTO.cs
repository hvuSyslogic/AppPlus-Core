using System;
using System.Runtime.Serialization;
using AppPlus.Infrastructure.Contract.Messages;

namespace HisPlus.Contract.Messages
{
    [Serializable]
    [DataContract]
    public class ElPatFormIllDTO : DtoBase<int>
    {
        public ElPatFormIllDTO()
        {
        }

        [DataMember]
        public int? PatFormId { get; set; }

        [DataMember]
        public int? ListNum { get; set; }

        [DataMember]
        public int? IcdId { get; set; }

        [DataMember]
        public string IllDesc { get; set; }

        [DataMember]
        public short? LsInOut { get; set; }

        [DataMember]
        public short? LsWestChin { get; set; }

        [DataMember]
        public int? Memo { get; set; }

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
