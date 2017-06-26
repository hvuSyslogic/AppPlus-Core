using System;
using System.Runtime.Serialization;
using AppPlus.Infrastructure.Contract.Messages;

namespace HisPlus.Contract.Messages
{
    [Serializable]
    [DataContract]
    public class ElPatRecordDTO : DtoBase<int>
    {
        public ElPatRecordDTO()
        {
        }

        [DataMember]
        public int? PatId { get; set; }

        [DataMember]
        public int? HospitalId { get; set; }

        [DataMember]
        public int GroupId { get; set; }

        [DataMember]
        public string RecNo { get; set; }

        [DataMember]
        public string Memo { get; set; }

        [DataMember]
        public System.DateTime OperTime { get; set; }

        [DataMember]
        public int OperId { get; set; }

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
