using System;
using System.Runtime.Serialization;
using AppPlus.Infrastructure.Contract.Messages;

namespace HisPlus.Contract.Messages
{
    [Serializable]
    [DataContract]
    public class DgRoadPatDTO : DtoBase<int>
    {
        public DgRoadPatDTO()
        {
        }

        [DataMember]
        public int? HospId { get; set; }

        [DataMember]
        public int RoadId { get; set; }

        [DataMember]
        public int? OperId { get; set; }

        [DataMember]
        public System.DateTime? OperTime { get; set; }

        [DataMember]
        public bool? IsChk { get; set; }

        [DataMember]
        public System.DateTime? ChkOperTime { get; set; }

        [DataMember]
        public int? ChkOperId { get; set; }
    }
}
