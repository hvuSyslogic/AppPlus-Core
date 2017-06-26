using System;
using System.Runtime.Serialization;
using AppPlus.Infrastructure.Contract.Messages;

namespace HisPlus.Contract.Messages
{
    [Serializable]
    [DataContract]
    public class InEmrSignDTO : DtoBase<int>
    {
        public InEmrSignDTO()
        {
        }

        [DataMember]
        public int? OperId { get; set; }

        [DataMember]
        public int? EmrId { get; set; }

        [DataMember]
        public string SignValue { get; set; }

        [DataMember]
        public System.DateTime? SignDate { get; set; }

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
