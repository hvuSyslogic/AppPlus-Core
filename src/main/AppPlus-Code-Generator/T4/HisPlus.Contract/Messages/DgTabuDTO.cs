using System;
using System.Runtime.Serialization;
using AppPlus.Infrastructure.Contract.Messages;

namespace HisPlus.Contract.Messages
{
    [Serializable]
    [DataContract]
    public class DgTabuDTO : DtoBase<int>
    {
        public DgTabuDTO()
        {
        }

        [DataMember]
        public int DrugId { get; set; }

        [DataMember]
        public int DrugId1 { get; set; }

        [DataMember]
        public int? DrugId2 { get; set; }

        [DataMember]
        public int? DrugId3 { get; set; }

        [DataMember]
        public int? DrugId4 { get; set; }

        [DataMember]
        public string LClass { get; set; }

        [DataMember]
        public string Expain { get; set; }

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
