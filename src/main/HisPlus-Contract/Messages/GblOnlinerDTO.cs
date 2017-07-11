using System;
using System.Runtime.Serialization;
using HisPlus.Infrastructure.Contract.Messages;

namespace HisPlus.Contract.Messages
{
    [Serializable]
    [DataContract]
    public class GblOnlinerDTO : DtoBase<int>
    {
        public GblOnlinerDTO()
        {
        }

        [DataMember]
        public int UserId { get; set; }

        [DataMember]
        public string WorkStationName { get; set; }

        [DataMember]
        public string LockIp { get; set; }

        [DataMember]
        public System.DateTime LoginTime { get; set; }
    }
}
