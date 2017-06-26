using System;
using System.Runtime.Serialization;
using AppPlus.Infrastructure.Contract.Messages;

namespace HisPlus.Contract.Messages
{
    [Serializable]
    [DataContract]
    public class RdLessonDTO : DtoBase<int>
    {
        public RdLessonDTO()
        {
        }

        [DataMember]
        public int LessonTypeId { get; set; }

        [DataMember]
        public System.DateTime? LessonTime { get; set; }

        [DataMember]
        public string Location { get; set; }

        [DataMember]
        public short? Numbers { get; set; }

        [DataMember]
        public string Company { get; set; }

        [DataMember]
        public string Occupation { get; set; }

        [DataMember]
        public string Teacher { get; set; }

        [DataMember]
        public string Title { get; set; }

        [DataMember]
        public string Content { get; set; }

        [DataMember]
        public System.DateTime? OperTime { get; set; }

        [DataMember]
        public int? OperId { get; set; }

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
