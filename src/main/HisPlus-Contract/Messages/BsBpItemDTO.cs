using System;
using System.Runtime.Serialization;
using HisPlus.Infrastructure.Contract.Messages;

namespace HisPlus.Contract.Messages
{
    [Serializable]
    [DataContract]
    public class BsBpItemDTO : DtoBase<int>
    {
        public BsBpItemDTO()
        {
        }

        [DataMember]
        public string Name { get; set; }

        [DataMember]
        public string PyCode { get; set; }

        [DataMember]
        public string WbCode { get; set; }

        [DataMember]
        public int? LsRpType { get; set; }

        [DataMember]
        public string YbCode { get; set; }
    }
}
