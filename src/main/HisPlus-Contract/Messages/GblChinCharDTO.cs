using System;
using System.Runtime.Serialization;
using AppPlus.Infrastructure.Contract.Messages;

namespace HisPlus.Contract.Messages
{
    [Serializable]
    [DataContract]
    public class GblChinCharDTO : DtoBase<int>
    {
        public GblChinCharDTO()
        {
        }

        [DataMember]
        public string Name { get; set; }

        [DataMember]
        public string PyCode { get; set; }

        [DataMember]
        public string PyChar { get; set; }

        [DataMember]
        public string WbCode { get; set; }

        [DataMember]
        public string WbChar { get; set; }

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