using System;
using System.Runtime.Serialization;
using AppPlus.Infrastructure.Contract.Messages;

namespace HisPlus.Contract.Messages
{
    [Serializable]
    [DataContract]
    public class PlItemDTO : DtoBase<int>
    {
        public PlItemDTO()
        {
        }

        [DataMember]
        public short GroupType { get; set; }

        [DataMember]
        public string Name { get; set; }

        [DataMember]
        public string Memo { get; set; }

        [DataMember]
        public short? Hours { get; set; }

        [DataMember]
        public int? ParentId { get; set; }

        [DataMember]
        public int OrderBy { get; set; }

        [DataMember]
        public bool IsActive { get; set; }

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