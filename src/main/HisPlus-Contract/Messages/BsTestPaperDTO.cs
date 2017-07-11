using System;
using System.Runtime.Serialization;
using HisPlus.Infrastructure.Contract.Messages;

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
    }
}
