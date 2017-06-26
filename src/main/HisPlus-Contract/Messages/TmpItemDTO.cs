using System;
using System.Runtime.Serialization;
using AppPlus.Infrastructure.Contract.Messages;

namespace HisPlus.Contract.Messages
{
    [Serializable]
    [DataContract]
    public class TmpItemDTO : DtoBase<int>
    {
        public TmpItemDTO()
        {
        }

        [DataMember]
        public int? MenuId { get; set; }

        [DataMember]
        public string CKey { get; set; }

        [DataMember]
        public string CType { get; set; }

        [DataMember]
        public string Value { get; set; }

        [DataMember]
        public int? LsType { get; set; }

        [DataMember]
        public int? OperId { get; set; }

        [DataMember]
        public string TempName { get; set; }
    }
}
