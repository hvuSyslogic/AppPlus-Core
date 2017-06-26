using System;
using System.Runtime.Serialization;
using AppPlus.Infrastructure.Contract.Messages;

namespace HisPlus.Contract.Messages
{
    [Serializable]
    [DataContract]
    public class InOpsSumDTO : DtoBase<int>
    {
        public InOpsSumDTO()
        {
        }

        [DataMember]
        public int LocationId { get; set; }

        [DataMember]
        public System.DateTime OperTime { get; set; }

        [DataMember]
        public int OperId { get; set; }

        [DataMember]
        public int SelectDateNum { get; set; }

        [DataMember]
        public int EmergencyNum { get; set; }

        [DataMember]
        public int OutPatientNum { get; set; }

        [DataMember]
        public string Memo { get; set; }
    }
}
