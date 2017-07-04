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
    }
}
