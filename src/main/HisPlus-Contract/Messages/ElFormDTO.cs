using System;
using System.Runtime.Serialization;
using AppPlus.Infrastructure.Contract.Messages;

namespace HisPlus.Contract.Messages
{
    [Serializable]
    [DataContract]
    public class ElFormDTO : DtoBase<int>
    {
        public ElFormDTO()
        {
        }

        [DataMember]
        public int PatMenuId { get; set; }

        [DataMember]
        public int? ElId { get; set; }

        [DataMember]
        public string X { get; set; }

        [DataMember]
        public string Y { get; set; }

        [DataMember]
        public string Title { get; set; }

        [DataMember]
        public bool? ReadOnly { get; set; }

        [DataMember]
        public short? OrderBy { get; set; }

        [DataMember]
        public bool? IsActive { get; set; }

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
