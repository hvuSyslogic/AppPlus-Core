using System;
using System.Runtime.Serialization;
using HisPlus.Infrastructure.Contract.Messages;

namespace HisPlus.Contract.Messages
{
    [Serializable]
    [DataContract]
    public class VisitRecordDTO : DtoBase<int>
    {
        public VisitRecordDTO()
        {
        }

        [DataMember]
        public System.DateTime? VisitTime { get; set; }

        [DataMember]
        public int? OperId { get; set; }

        [DataMember]
        public System.DateTime? OperTime { get; set; }

        [DataMember]
        public short? VisitType { get; set; }

        [DataMember]
        public string VisitContent { get; set; }

        [DataMember]
        public int PatId { get; set; }

        [DataMember]
        public int MzRegId { get; set; }

        [DataMember]
        public string BackContent { get; set; }

        [DataMember]
        public short? VisitStatus { get; set; }

        [DataMember]
        public short? AppraiseType { get; set; }
    }
}
