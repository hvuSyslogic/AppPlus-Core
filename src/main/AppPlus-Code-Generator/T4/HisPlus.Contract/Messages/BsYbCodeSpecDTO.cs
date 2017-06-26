using System;
using System.Runtime.Serialization;
using AppPlus.Infrastructure.Contract.Messages;

namespace HisPlus.Contract.Messages
{
    [Serializable]
    [DataContract]
    public class BsYbCodeSpecDTO : DtoBase<int>
    {
        public BsYbCodeSpecDTO()
        {
        }

        [DataMember]
        public int ItemId { get; set; }

        [DataMember]
        public int TallyGroupId { get; set; }

        [DataMember]
        public int? IcdId { get; set; }

        [DataMember]
        public string YbCode { get; set; }

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
