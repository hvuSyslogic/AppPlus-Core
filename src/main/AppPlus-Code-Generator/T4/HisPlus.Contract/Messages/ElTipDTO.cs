using System;
using System.Runtime.Serialization;
using AppPlus.Infrastructure.Contract.Messages;

namespace HisPlus.Contract.Messages
{
    [Serializable]
    [DataContract]
    public class ElTipDTO : DtoBase<int>
    {
        public ElTipDTO()
        {
        }

        [DataMember]
        public int? PatMenuId { get; set; }

        [DataMember]
        public string WhereFormat { get; set; }

        [DataMember]
        public string Arg1 { get; set; }

        [DataMember]
        public string Arg2 { get; set; }

        [DataMember]
        public string Arg3 { get; set; }

        [DataMember]
        public string Arg4 { get; set; }

        [DataMember]
        public string Arg5 { get; set; }

        [DataMember]
        public string Tips { get; set; }

        [DataMember]
        public bool? IsFollow { get; set; }

        [DataMember]
        public short? ActiveDays { get; set; }

        [DataMember]
        public string RoleIds { get; set; }

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
