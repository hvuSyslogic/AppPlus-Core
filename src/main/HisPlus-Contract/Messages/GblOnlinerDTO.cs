using System;
using System.Runtime.Serialization;
using AppPlus.Infrastructure.Contract.Messages;

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
