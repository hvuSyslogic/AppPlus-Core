using System;
using System.Runtime.Serialization;
using AppPlus.Infrastructure.Contract.Messages;

namespace HisPlus.Contract.Messages
{
    [Serializable]
    [DataContract]
    public class ElPatFormValueDTO : DtoBase<int>
    {
        public ElPatFormValueDTO()
        {
        }

        [DataMember]
        public int? PatFormId { get; set; }

        [DataMember]
        public int? ElId { get; set; }

        [DataMember]
        public string ElValue { get; set; }

        [DataMember]
        public string F1 { get; set; }

        [DataMember]
        public string F2 { get; set; }

        [DataMember]
        public string F3 { get; set; }

        [DataMember]
        public string F4 { get; set; }

        [DataMember]
        public short? LsType { get; set; }

        [DataMember]
        public int? ClassId { get; set; }
    }
}
