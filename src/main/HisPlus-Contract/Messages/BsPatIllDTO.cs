using System;
using System.Runtime.Serialization;
using AppPlus.Infrastructure.Contract.Messages;

namespace HisPlus.Contract.Messages
{
    [Serializable]
    [DataContract]
    public class BsPatIllDTO : DtoBase<int>
    {
        public BsPatIllDTO()
        {
        }

        [DataMember]
        public int PatId { get; set; }

        [DataMember]
        public int? IcdId { get; set; }

        [DataMember]
        public string IllDesc { get; set; }

        [DataMember]
        public short? LsWestChin { get; set; }

        [DataMember]
        public System.DateTime? IllTime { get; set; }

        [DataMember]
        public string ConfirmDoctor { get; set; }

        [DataMember]
        public short? LsEffect { get; set; }

        [DataMember]
        public System.DateTime? OperTime { get; set; }

        [DataMember]
        public int? OperId { get; set; }

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
