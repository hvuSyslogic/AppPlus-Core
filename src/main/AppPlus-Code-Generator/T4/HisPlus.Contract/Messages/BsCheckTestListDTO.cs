using System;
using System.Runtime.Serialization;
using AppPlus.Infrastructure.Contract.Messages;

namespace HisPlus.Contract.Messages
{
    [Serializable]
    [DataContract]
    public class BsCheckTestListDTO : DtoBase<int>
    {
        public BsCheckTestListDTO()
        {
        }

        [DataMember]
        public int? IllId { get; set; }

        [DataMember]
        public string IllName { get; set; }

        [DataMember]
        public string GroupType { get; set; }

        [DataMember]
        public string CheckTestType { get; set; }

        [DataMember]
        public int? ItemId { get; set; }

        [DataMember]
        public string ItemName { get; set; }

        [DataMember]
        public string ItemDesc { get; set; }

        [DataMember]
        public string ItemResult { get; set; }
    }
}
