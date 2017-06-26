using System;
using System.Runtime.Serialization;
using AppPlus.Infrastructure.Contract.Messages;

namespace HisPlus.Contract.Messages
{
    [Serializable]
    [DataContract]
    public class CkItemResultDTO : DtoBase<int>
    {
        public CkItemResultDTO()
        {
        }

        [DataMember]
        public int TestId { get; set; }

        [DataMember]
        public string Result { get; set; }

        [DataMember]
        public bool IsBold { get; set; }

        [DataMember]
        public bool IsPass { get; set; }

        [DataMember]
        public string F1 { get; set; }

        [DataMember]
        public string F2 { get; set; }

        [DataMember]
        public string F3 { get; set; }

        [DataMember]
        public string F4 { get; set; }

        [DataMember]
        public string Summary { get; set; }

        [DataMember]
        public string DoctorAdvice { get; set; }
    }
}
