using System;
using System.Runtime.Serialization;
using AppPlus.Infrastructure.Contract.Messages;

namespace HisPlus.Contract.Messages
{
    [Serializable]
    [DataContract]
    public class NfInfectReasonDTO : DtoBase<int>
    {
        public NfInfectReasonDTO()
        {
        }

        [DataMember]
        public int InfectId { get; set; }

        [DataMember]
        public int InfReasonId { get; set; }

        [DataMember]
        public bool? IsRelated { get; set; }

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
