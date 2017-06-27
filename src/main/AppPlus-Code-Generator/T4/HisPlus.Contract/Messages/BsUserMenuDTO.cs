using System;
using System.Runtime.Serialization;
using AppPlus.Infrastructure.Contract.Messages;

namespace HisPlus.Contract.Messages
{
    [Serializable]
    [DataContract]
    public class BsUserMenuDTO : DtoBase<int>
    {
        public BsUserMenuDTO()
        {
        }

        [DataMember]
        public int OperId { get; set; }

        [DataMember]
        public int? MenuId { get; set; }

        [DataMember]
        public int? OrderBy { get; set; }

        [DataMember]
        public string F1 { get; set; }

        [DataMember]
        public string F2 { get; set; }

        [DataMember]
        public string F3 { get; set; }

        [DataMember]
        public string F4 { get; set; }

        [DataMember]
        public short IconIndex { get; set; }
    }
}