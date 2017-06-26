using System;
using System.Runtime.Serialization;
using AppPlus.Infrastructure.Contract.Messages;

namespace HisPlus.Contract.Messages
{
    [Serializable]
    [DataContract]
    public class PlProjectDTO : DtoBase<int>
    {
        public PlProjectDTO()
        {
        }

        [DataMember]
        public string Name { get; set; }

        [DataMember]
        public int ChargeOperId { get; set; }

        [DataMember]
        public System.DateTime RecTime { get; set; }

        [DataMember]
        public bool? IsClose { get; set; }

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
