using System;
using System.Runtime.Serialization;
using AppPlus.Infrastructure.Contract.Messages;

namespace HisPlus.Contract.Messages
{
    [Serializable]
    [DataContract]
    public class InHosOpDTO : DtoBase<int>
    {
        public InHosOpDTO()
        {
        }

        [DataMember]
        public int HospId { get; set; }

        [DataMember]
        public int OpsTimes { get; set; }

        [DataMember]
        public System.DateTime? OpsTime { get; set; }

        [DataMember]
        public int? OpsId { get; set; }

        [DataMember]
        public short? LsCut { get; set; }

        [DataMember]
        public short? LsRecove { get; set; }

        [DataMember]
        public int? OpsDoctorId { get; set; }

        [DataMember]
        public int? AnaesId { get; set; }

        [DataMember]
        public int? AssistantOperId1 { get; set; }

        [DataMember]
        public int? AssistantOperId2 { get; set; }

        [DataMember]
        public int? AnaesDoctorId { get; set; }

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
