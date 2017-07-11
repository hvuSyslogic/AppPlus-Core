using System;
using System.Runtime.Serialization;
using HisPlus.Infrastructure.Contract.Messages;

namespace HisPlus.Contract.Messages
{
    [Serializable]
    [DataContract]
    public class BsUserHouseDTO : DtoBase<int>
    {
        public BsUserHouseDTO()
        {
        }

        [DataMember]
        public int OperId { get; set; }

        [DataMember]
        public int HouseId { get; set; }

        [DataMember]
        public short IconIndex { get; set; }
    }
}
