using System;
using System.Runtime.Serialization;
using HisPlus.Infrastructure.Contract.Messages;

namespace HisPlus.Contract.Messages
{
    [Serializable]
    [DataContract]
    public class TrPractiseDTO : DtoBase<int>
    {
        public TrPractiseDTO()
        {
        }

        [DataMember]
        public string Hospital { get; set; }

        [DataMember]
        public int? OriId { get; set; }

        [DataMember]
        public System.DateTime? OperTime { get; set; }

        [DataMember]
        public System.DateTime? PractiseTime { get; set; }

        [DataMember]
        public byte? DebugMode { get; set; }

        [DataMember]
        public string Funtion { get; set; }

        [DataMember]
        public string UserName { get; set; }

        [DataMember]
        public string RoleName { get; set; }

        [DataMember]
        public string LocationName { get; set; }

        [DataMember]
        public string Memo { get; set; }
    }
}
