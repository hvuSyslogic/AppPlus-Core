using System;
using System.Runtime.Serialization;
using AppPlus.Infrastructure.Contract.Messages;

namespace HisPlus.Contract.Messages
{
    [Serializable]
    [DataContract]
    public class NfInfectDTO : DtoBase<int>
    {
        public NfInfectDTO()
        {
        }

        [DataMember]
        public short LsInfectType { get; set; }

        [DataMember]
        public string Code { get; set; }

        [DataMember]
        public int HospId { get; set; }

        [DataMember]
        public short LsEffect { get; set; }

        [DataMember]
        public short LsCutType { get; set; }

        [DataMember]
        public System.DateTime InfectTime { get; set; }

        [DataMember]
        public System.DateTime OperTime { get; set; }

        [DataMember]
        public int OperId { get; set; }

        [DataMember]
        public int PositionId { get; set; }

        [DataMember]
        public int LocationId { get; set; }

        [DataMember]
        public int SpecialityId { get; set; }

        [DataMember]
        public short? LsInfluence { get; set; }

        [DataMember]
        public string F1 { get; set; }

        [DataMember]
        public string F2 { get; set; }

        [DataMember]
        public string F3 { get; set; }

        [DataMember]
        public string F4 { get; set; }

        [DataMember]
        public int? OpsId { get; set; }

        [DataMember]
        public System.DateTime? OpsTime { get; set; }

        [DataMember]
        public short? LsClass { get; set; }

        [DataMember]
        public short? LsAsa { get; set; }

        [DataMember]
        public bool? IsEmergency { get; set; }

        [DataMember]
        public int? AnaesId { get; set; }

        [DataMember]
        public int? Minutes { get; set; }

        [DataMember]
        public bool? IsImplant { get; set; }

        [DataMember]
        public bool? IsImglass { get; set; }

        [DataMember]
        public bool? IsOpsDrug { get; set; }

        [DataMember]
        public bool? IsUseDrug { get; set; }

        [DataMember]
        public short? LsInfectRange { get; set; }

        [DataMember]
        public short? LsUseType { get; set; }

        [DataMember]
        public short? LsUnionDrug { get; set; }

        [DataMember]
        public short? LsUsePurpose { get; set; }

        [DataMember]
        public int? DoctorId { get; set; }
    }
}
