using System;
using System.Runtime.Serialization;
using AppPlus.Infrastructure.Contract.Messages;

namespace HisPlus.Contract.Messages
{
    [Serializable]
    [DataContract]
    public class BsItemPeopleDTO : DtoBase<int>
    {
        public BsItemPeopleDTO()
        {
        }

        [DataMember]
        public int ItemId { get; set; }

        [DataMember]
        public string Sex { get; set; }

        [DataMember]
        public int AgeFrom { get; set; }

        [DataMember]
        public int AgeTo { get; set; }

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
