using System;
using System.Runtime.Serialization;
using HisPlus.Infrastructure.Contract.Messages;

namespace HisPlus.Contract.Messages
{
    [Serializable]
    [DataContract]
    public class CkResultGroupDTO : DtoBase<int>
    {
        public CkResultGroupDTO()
        {
        }

        [DataMember]
        public int TestGroupId { get; set; }

        [DataMember]
        public int CheckId { get; set; }

        [DataMember]
        public string CheckDesc { get; set; }

        [DataMember]
        public string Summary { get; set; }

        [DataMember]
        public string DoctorAdvice { get; set; }

        [DataMember]
        public short? LsStatus { get; set; }

        [DataMember]
        public System.DateTime? ResultTime { get; set; }

        [DataMember]
        public int? ResultOperId { get; set; }

        [DataMember]
        public System.DateTime? AuthTime { get; set; }

        [DataMember]
        public int? AuthOperId { get; set; }
    }
}
