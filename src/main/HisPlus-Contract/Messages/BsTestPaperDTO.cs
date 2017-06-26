using System;
using System.Runtime.Serialization;
using AppPlus.Infrastructure.Contract.Messages;

namespace HisPlus.Contract.Messages
{
    [Serializable]
    [DataContract]
    public class BsTestPaperDTO : DtoBase<int>
    {
        public BsTestPaperDTO()
        {
        }

        [DataMember]
        public string Name { get; set; }

        [DataMember]
        public int UserId { get; set; }

        [DataMember]
        public System.DateTime GenerateTime { get; set; }

        [DataMember]
        public string QuestionId { get; set; }

        [DataMember]
        public string UsersId { get; set; }

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
