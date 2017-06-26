using System;
using System.Runtime.Serialization;
using AppPlus.Infrastructure.Contract.Messages;

namespace HisPlus.Contract.Messages
{
    [Serializable]
    [DataContract]
    public class BsPatTypeYbIllDTO : DtoBase<int>
    {
        public BsPatTypeYbIllDTO()
        {
        }

        [DataMember]
        public int? TallyTypeId { get; set; }

        [DataMember]
        public int? PatTypeId { get; set; }

        [DataMember]
        public string YbCode { get; set; }

        [DataMember]
        public string YbDesc { get; set; }

        [DataMember]
        public string IllIds { get; set; }

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
