using System;
using System.Runtime.Serialization;
using AppPlus.Infrastructure.Contract.Messages;

namespace HisPlus.Contract.Messages
{
    [Serializable]
    [DataContract]
    public class OaScheduleDTO : DtoBase<int>
    {
        public OaScheduleDTO()
        {
        }

        [DataMember]
        public System.DateTime OperTime { get; set; }

        [DataMember]
        public int OperId { get; set; }

        [DataMember]
        public string Subject { get; set; }

        [DataMember]
        public string Location { get; set; }

        [DataMember]
        public System.DateTime? StartTime { get; set; }

        [DataMember]
        public System.DateTime? EndTime { get; set; }

        [DataMember]
        public string Description { get; set; }

        [DataMember]
        public int? LabelId { get; set; }

        [DataMember]
        public System.DateTime? Reminder { get; set; }
    }
}
