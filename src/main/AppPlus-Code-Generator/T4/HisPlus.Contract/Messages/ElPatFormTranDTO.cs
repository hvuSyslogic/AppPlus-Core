using System;
using System.Runtime.Serialization;
using AppPlus.Infrastructure.Contract.Messages;

namespace HisPlus.Contract.Messages
{
    [Serializable]
    [DataContract]
    public class ElPatFormTranDTO : DtoBase<int>
    {
        public ElPatFormTranDTO()
        {
        }

        [DataMember]
        public int? PatFormId { get; set; }

        [DataMember]
        public string F1 { get; set; }

        [DataMember]
        public string F2 { get; set; }

        [DataMember]
        public string F3 { get; set; }

        [DataMember]
        public string F4 { get; set; }

        [DataMember]
        public string RecNo { get; set; }

        [DataMember]
        public System.DateTime? ChangeTime { get; set; }

        [DataMember]
        public int? ChangeOperId { get; set; }

        [DataMember]
        public string Reason { get; set; }

        [DataMember]
        public string FromHospital { get; set; }

        [DataMember]
        public string ToHospital { get; set; }

        [DataMember]
        public System.DateTime? RecieveTime { get; set; }

        [DataMember]
        public int? RecieveOperId { get; set; }

        [DataMember]
        public string Disposal { get; set; }

        [DataMember]
        public string Diagnose { get; set; }

        [DataMember]
        public string Memo { get; set; }
    }
}
