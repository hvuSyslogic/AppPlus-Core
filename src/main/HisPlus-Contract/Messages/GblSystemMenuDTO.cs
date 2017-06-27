using System;
using System.Runtime.Serialization;
using AppPlus.Infrastructure.Contract.Messages;

namespace HisPlus.Contract.Messages
{
    [Serializable]
    [DataContract]
    public class GblSystemMenuDTO : DtoBase<int>
    {
        public GblSystemMenuDTO()
        {
        }

        [DataMember]
        public int SystemId { get; set; }

        [DataMember]
        public string Code { get; set; }

        [DataMember]
        public string Name { get; set; }

        [DataMember]
        public short? IconIndex { get; set; }

        [DataMember]
        public string Hint { get; set; }

        [DataMember]
        public string Shortcut { get; set; }

        [DataMember]
        public int? ParentId { get; set; }

        [DataMember]
        public short? OrderBy { get; set; }

        [DataMember]
        public bool? IsMostUsed { get; set; }

        [DataMember]
        public bool? IsBeginGroup { get; set; }

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