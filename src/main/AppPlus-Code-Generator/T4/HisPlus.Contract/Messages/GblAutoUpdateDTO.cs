using System;
using System.Runtime.Serialization;
using AppPlus.Infrastructure.Contract.Messages;

namespace HisPlus.Contract.Messages
{
    [Serializable]
    [DataContract]
    public class GblAutoUpdateDTO : DtoBase<int>
    {
        public GblAutoUpdateDTO()
        {
        }

        [DataMember]
        public string PathName { get; set; }

        [DataMember]
        public byte[] FileContent { get; set; }

        [DataMember]
        public System.DateTime? OldVersion { get; set; }

        [DataMember]
        public System.DateTime NewVersion { get; set; }

        [DataMember]
        public string UpLoadHostName { get; set; }

        [DataMember]
        public string UpLoadIp { get; set; }

        [DataMember]
        public System.DateTime OperTime { get; set; }

        [DataMember]
        public int OperId { get; set; }

        [DataMember]
        public string DownLoadHostNames { get; set; }

        [DataMember]
        public string F1 { get; set; }

        [DataMember]
        public string F2 { get; set; }

        [DataMember]
        public string F3 { get; set; }

        [DataMember]
        public string F4 { get; set; }

        [DataMember]
        public string HospitalIds { get; set; }
    }
}
