using System;
using System.Runtime.Serialization;
using AppPlus.Infrastructure.Contract.Messages;

namespace HisPlus.Contract.Messages
{
    [Serializable]
    [DataContract]
    public class BsItemNameMultiDTO : DtoBase<int>
    {
        public BsItemNameMultiDTO()
        {
        }

        [DataMember]
        public int ItemId { get; set; }

        [DataMember]
        public string NameMulti { get; set; }

        [DataMember]
        public string WbMulti { get; set; }

        [DataMember]
        public string PyMulti { get; set; }

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
