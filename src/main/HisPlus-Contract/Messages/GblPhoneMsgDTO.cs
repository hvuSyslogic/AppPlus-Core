using System;
using System.Runtime.Serialization;
using AppPlus.Infrastructure.Contract.Messages;

namespace HisPlus.Contract.Messages
{
    [Serializable]
    [DataContract]
    public class GblPhoneMsgDTO : DtoBase<int>
    {
        public GblPhoneMsgDTO()
        {
        }

        [DataMember]
        public string PhoneNum { get; set; }

        [DataMember]
        public string Name { get; set; }

        [DataMember]
        public string Message { get; set; }

        [DataMember]
        public System.DateTime? PlanTime { get; set; }

        [DataMember]
        public bool? IsSend { get; set; }

        [DataMember]
        public System.DateTime? SendTime { get; set; }

        [DataMember]
        public int? OperId { get; set; }

        [DataMember]
        public System.DateTime? OperTime { get; set; }
    }
}
