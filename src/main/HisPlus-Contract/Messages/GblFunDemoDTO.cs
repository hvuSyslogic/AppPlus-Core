using System;
using System.Runtime.Serialization;
using AppPlus.Infrastructure.Contract.Messages;

namespace HisPlus.Contract.Messages
{
    [Serializable]
    [DataContract]
    public class GblFunDemoDTO : DtoBase<int>
    {
        public GblFunDemoDTO()
        {
        }

        [DataMember]
        public string Purpose { get; set; }

        [DataMember]
        public int? FuntionId { get; set; }

        [DataMember]
        public string Memo { get; set; }

        [DataMember]
        public int? OrderBy { get; set; }

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
