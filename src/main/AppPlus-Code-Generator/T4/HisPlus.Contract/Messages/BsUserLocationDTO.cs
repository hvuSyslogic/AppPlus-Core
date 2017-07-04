using System;
using System.Runtime.Serialization;
using AppPlus.Infrastructure.Contract.Messages;

namespace HisPlus.Contract.Messages
{
    [Serializable]
    [DataContract]
    public class BsUserLocationDTO : DtoBase<int>
    {
        public BsUserLocationDTO()
        {
        }

        [DataMember]
        public int OperId { get; set; }

        [DataMember]
        public int LocationId { get; set; }

        [DataMember]
        public short IconIndex { get; set; }
    }
}
