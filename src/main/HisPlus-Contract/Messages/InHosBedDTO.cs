using System;
using System.Runtime.Serialization;
using AppPlus.Infrastructure.Contract.Messages;

namespace HisPlus.Contract.Messages
{
    [Serializable]
    [DataContract]
    public class InHosBedDTO : DtoBase<int>
    {
        public InHosBedDTO()
        {
        }

        [DataMember]
        public int HospId { get; set; }

        [DataMember]
        public int BedId { get; set; }

        [DataMember]
        public System.DateTime OperTime { get; set; }

        [DataMember]
        public int OperId { get; set; }
    }
}
