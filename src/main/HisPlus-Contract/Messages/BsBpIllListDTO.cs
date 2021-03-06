using System;
using System.Runtime.Serialization;
using HisPlus.Infrastructure.Contract.Messages;

namespace HisPlus.Contract.Messages
{
    [Serializable]
    [DataContract]
    public class BsBpIllListDTO : DtoBase<int>
    {
        public BsBpIllListDTO()
        {
        }

        [DataMember]
        public int? BpIllId { get; set; }

        [DataMember]
        public string BpIllName { get; set; }

        [DataMember]
        public string WbCode { get; set; }

        [DataMember]
        public string PyCode { get; set; }
    }
}
