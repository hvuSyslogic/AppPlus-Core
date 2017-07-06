using System;
using System.Runtime.Serialization;
using AppPlus.Infrastructure.Contract.Messages;

namespace HisPlus.Contract.Messages
{
    [Serializable]
    [DataContract]
    public class VisitMessageLogDTO : DtoBase<int>
    {
        public VisitMessageLogDTO()
        {
        }

        [DataMember]
        public int PatId { get; set; }

        [DataMember]
        public string PatientName { get; set; }

        [DataMember]
        public string Mobile { get; set; }

        [DataMember]
        public string Comments { get; set; }

        [DataMember]
        public int? OperId { get; set; }

        [DataMember]
        public System.DateTime? OperTime { get; set; }
    }
}
