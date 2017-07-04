using System;
using System.Runtime.Serialization;
using AppPlus.Infrastructure.Contract.Messages;

namespace HisPlus.Contract.Messages
{
    [Serializable]
    [DataContract]
    public class GblFuctionDTO : DtoBase<int>
    {
        public GblFuctionDTO()
        {
        }

        [DataMember]
        public int? MenuId { get; set; }

        [DataMember]
        public string Title { get; set; }

        [DataMember]
        public string Content { get; set; }

        [DataMember]
        public string Memo { get; set; }

        [DataMember]
        public bool? IsTest { get; set; }

        [DataMember]
        public short? LsClass { get; set; }

        [DataMember]
        public int OrderBy { get; set; }

        [DataMember]
        public string Code { get; set; }
    }
}
