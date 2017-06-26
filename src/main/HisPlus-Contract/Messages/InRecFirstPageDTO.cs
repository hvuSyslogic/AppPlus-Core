using System;
using System.Runtime.Serialization;
using AppPlus.Infrastructure.Contract.Messages;

namespace HisPlus.Contract.Messages
{
    [Serializable]
    [DataContract]
    public class InRecFirstPageDTO : DtoBase<int>
    {
        public InRecFirstPageDTO()
        {
        }

        [DataMember]
        public string RecNo { get; set; }

        [DataMember]
        public int HospId { get; set; }

        [DataMember]
        public System.DateTime OperTime { get; set; }

        [DataMember]
        public int OperId { get; set; }

        [DataMember]
        public System.DateTime? ModifyOperTime { get; set; }

        [DataMember]
        public int? ModifyOperId { get; set; }

        [DataMember]
        public bool IsAuth { get; set; }

        [DataMember]
        public System.DateTime? AuthOperTime { get; set; }

        [DataMember]
        public int? AuthOperId { get; set; }

        [DataMember]
        public string F1 { get; set; }

        [DataMember]
        public string F2 { get; set; }

        [DataMember]
        public string F3 { get; set; }

        [DataMember]
        public string F4 { get; set; }

        [DataMember]
        public System.DateTime? ConfirmIllDate { get; set; }

        [DataMember]
        public bool IsOps { get; set; }

        [DataMember]
        public bool IsBabyCard { get; set; }

        [DataMember]
        public bool IsMutiIll { get; set; }

        [DataMember]
        public int InfectTimes { get; set; }

        [DataMember]
        public bool IsSalvage { get; set; }

        [DataMember]
        public int SalvageTimes { get; set; }

        [DataMember]
        public bool IsSalvSucess { get; set; }

        [DataMember]
        public int SalvSucessTimes { get; set; }

        [DataMember]
        public bool IsFollow { get; set; }

        [DataMember]
        public System.DateTime? FollowEndDate { get; set; }

        [DataMember]
        public bool IsDeadBodyCheck { get; set; }

        [DataMember]
        public bool IsStudyCase { get; set; }

        [DataMember]
        public short LsQuality { get; set; }

        [DataMember]
        public int? ZrDoctorId { get; set; }

        [DataMember]
        public int? ZzDoctorId { get; set; }

        [DataMember]
        public int? ZyDoctorId { get; set; }

        [DataMember]
        public int? SxDoctorId { get; set; }

        [DataMember]
        public int? JxDoctorId { get; set; }

        [DataMember]
        public int? YjsDoctorId { get; set; }

        [DataMember]
        public int? ZkDoctorId { get; set; }

        [DataMember]
        public short LsAccMzIll { get; set; }

        [DataMember]
        public short LsAccZyIll { get; set; }

        [DataMember]
        public short LsAccOpsIll1 { get; set; }

        [DataMember]
        public short LsAccOpsIll2 { get; set; }

        [DataMember]
        public short LsAccOpsIll3 { get; set; }

        [DataMember]
        public short LsAccOpsIll4 { get; set; }

        [DataMember]
        public bool IsTjIll { get; set; }

        [DataMember]
        public bool IsConfirm3D { get; set; }

        [DataMember]
        public int BabyNum { get; set; }

        [DataMember]
        public bool IsTranNeact { get; set; }

        [DataMember]
        public bool IsOxygenNeact { get; set; }

        [DataMember]
        public bool IsMidFireBurn { get; set; }

        [DataMember]
        public bool IsSingleIll { get; set; }

        [DataMember]
        public bool IsHbsAg { get; set; }

        [DataMember]
        public bool IsHcvAb { get; set; }

        [DataMember]
        public bool IsHivAb { get; set; }

        [DataMember]
        public bool IsHbsAg3 { get; set; }

        [DataMember]
        public int? HeadOperId { get; set; }

        [DataMember]
        public int? ZkOperId { get; set; }

        [DataMember]
        public System.DateTime? ZkDate { get; set; }

        [DataMember]
        public bool IsRh { get; set; }

        [DataMember]
        public bool IsOpsFirst { get; set; }

        [DataMember]
        public bool IsCureFirst { get; set; }

        [DataMember]
        public bool IsCheckFirst { get; set; }

        [DataMember]
        public bool IsDiagFirst { get; set; }

        [DataMember]
        public int? RedCellNum { get; set; }

        [DataMember]
        public int? PlaqueNum { get; set; }

        [DataMember]
        public int? SerousNum { get; set; }

        [DataMember]
        public int? AllBloodNum { get; set; }

        [DataMember]
        public int? OtherBloodNum { get; set; }

        [DataMember]
        public int? ConsultHosputal { get; set; }

        [DataMember]
        public int? ConsultRemote { get; set; }
    }
}
