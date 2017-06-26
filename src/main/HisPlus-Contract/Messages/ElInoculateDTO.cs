using System;
using System.Runtime.Serialization;
using AppPlus.Infrastructure.Contract.Messages;

namespace HisPlus.Contract.Messages
{
    [Serializable]
    [DataContract]
    public class ElInoculateDTO : DtoBase<int>
    {
        public ElInoculateDTO()
        {
        }

        [DataMember]
        public int PatId { get; set; }

        [DataMember]
        public int? HospitalId { get; set; }

        [DataMember]
        public int ItemId { get; set; }

        [DataMember]
        public short NTime { get; set; }

        [DataMember]
        public System.DateTime PlanTime { get; set; }

        [DataMember]
        public int PlanOperId { get; set; }

        [DataMember]
        public string Memo { get; set; }

        [DataMember]
        public bool IsInoculate { get; set; }

        [DataMember]
        public System.DateTime? InoTime { get; set; }

        [DataMember]
        public int? InoOperId { get; set; }

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
