using System;
using System.Runtime.Serialization;
using AppPlus.Infrastructure.Contract.Messages;

namespace HisPlus.Contract.Messages
{
    [Serializable]
    [DataContract]
    public class NfInfectTestDTO : DtoBase<int>
    {
        public NfInfectTestDTO()
        {
        }

        [DataMember]
        public int InfectId { get; set; }

        [DataMember]
        public string LabNo { get; set; }

        [DataMember]
        public int SourceId { get; set; }

        [DataMember]
        public System.DateTime LabTime { get; set; }

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
