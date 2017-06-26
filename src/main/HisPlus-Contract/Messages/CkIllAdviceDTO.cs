using System;
using System.Runtime.Serialization;
using AppPlus.Infrastructure.Contract.Messages;

namespace HisPlus.Contract.Messages
{
    [Serializable]
    [DataContract]
    public class CkIllAdviceDTO : DtoBase<int>
    {
        public CkIllAdviceDTO()
        {
        }

        [DataMember]
        public int? TestTypeId { get; set; }

        [DataMember]
        public string Code { get; set; }

        [DataMember]
        public string IllDesc { get; set; }

        [DataMember]
        public string OrderBy { get; set; }

        [DataMember]
        public string Advice { get; set; }

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
