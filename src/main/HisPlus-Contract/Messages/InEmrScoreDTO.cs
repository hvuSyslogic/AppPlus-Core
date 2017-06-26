using System;
using System.Runtime.Serialization;
using AppPlus.Infrastructure.Contract.Messages;

namespace HisPlus.Contract.Messages
{
    [Serializable]
    [DataContract]
    public class InEmrScoreDTO : DtoBase<int>
    {
        public InEmrScoreDTO()
        {
        }

        [DataMember]
        public int? Emrqcitemid { get; set; }

        [DataMember]
        public int? Hospid { get; set; }

        [DataMember]
        public string Emritemscore { get; set; }

        [DataMember]
        public string Emrscore { get; set; }

        [DataMember]
        public bool? Isscore { get; set; }

        [DataMember]
        public string F1 { get; set; }

        [DataMember]
        public string F2 { get; set; }

        [DataMember]
        public string F3 { get; set; }

        [DataMember]
        public string F4 { get; set; }

        [DataMember]
        public string Partscore { get; set; }
    }
}
