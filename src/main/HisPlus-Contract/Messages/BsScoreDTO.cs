using System;
using System.Runtime.Serialization;
using AppPlus.Infrastructure.Contract.Messages;

namespace HisPlus.Contract.Messages
{
    [Serializable]
    [DataContract]
    public class BsScoreDTO : DtoBase<int>
    {
        public BsScoreDTO()
        {
        }

        [DataMember]
        public int UserId { get; set; }

        [DataMember]
        public int TestPaperId { get; set; }

        [DataMember]
        public int Score { get; set; }

        [DataMember]
        public string Answer { get; set; }
    }
}
