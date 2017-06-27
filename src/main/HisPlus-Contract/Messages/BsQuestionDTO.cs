using System;
using System.Runtime.Serialization;
using AppPlus.Infrastructure.Contract.Messages;

namespace HisPlus.Contract.Messages
{
    [Serializable]
    [DataContract]
    public class BsQuestionDTO : DtoBase<int>
    {
        public BsQuestionDTO()
        {
        }

        [DataMember]
        public string Question { get; set; }

        [DataMember]
        public string Answer { get; set; }

        [DataMember]
        public string OptionA { get; set; }

        [DataMember]
        public string OptionB { get; set; }

        [DataMember]
        public string OptionC { get; set; }

        [DataMember]
        public string OptionD { get; set; }

        [DataMember]
        public int SubjectId { get; set; }

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