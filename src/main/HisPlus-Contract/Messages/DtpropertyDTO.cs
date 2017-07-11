using System;
using System.Runtime.Serialization;
using HisPlus.Infrastructure.Contract.Messages;

namespace HisPlus.Contract.Messages
{
    [Serializable]
    [DataContract]
    public class DtpropertyDTO : DtoBase<int>
    {
        public DtpropertyDTO()
        {
        }

        [DataMember]
        public int? Objectid { get; set; }

        [DataMember]
        public string Value { get; set; }

        [DataMember]
        public string Uvalue { get; set; }

        [DataMember]
        public byte[] Lvalue { get; set; }

        [DataMember]
        public int Version { get; set; }
    }
}
