using System;
using System.Runtime.Serialization;
using HisPlus.Infrastructure.Contract.Messages;

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
    }
}
