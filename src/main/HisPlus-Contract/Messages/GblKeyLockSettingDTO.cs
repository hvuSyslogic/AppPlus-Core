using System;
using System.Runtime.Serialization;
using HisPlus.Infrastructure.Contract.Messages;

namespace HisPlus.Contract.Messages
{
    [Serializable]
    [DataContract]
    public class GblKeyLockSettingDTO : DtoBase<int>
    {
        public GblKeyLockSettingDTO()
        {
        }

        [DataMember]
        public short KeyTypeId { get; set; }

        [DataMember]
        public string KeyValue { get; set; }

        [DataMember]
        public string WorkStationName { get; set; }

        [DataMember]
        public string UserId { get; set; }

        [DataMember]
        public string UserName { get; set; }

        [DataMember]
        public string LockIp { get; set; }

        [DataMember]
        public System.DateTime LockTime { get; set; }

        [DataMember]
        public int Spid { get; set; }

        [DataMember]
        public System.DateTime LoginTime { get; set; }
    }
}
