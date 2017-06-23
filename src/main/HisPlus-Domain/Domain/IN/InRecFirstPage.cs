using AppPlus.Infrastructure.Contract.Messages;
using System.Data.Entity.ModelConfiguration;

namespace HisPlus.Domain
{
    public class InRecFirstPage : EntityBase<int>
    {
        public InRecFirstPage()
        {    
        }

        public string RecNo { get; set; }
        public int HospId { get; set; }
        public System.DateTime OperTime { get; set; }
        public int OperId { get; set; }
        public System.DateTime? ModifyOperTime { get; set; }
        public int? ModifyOperId { get; set; }
        public bool IsAuth { get; set; }
        public System.DateTime? AuthOperTime { get; set; }
        public int? AuthOperId { get; set; }
        public string F1 { get; set; }
        public string F2 { get; set; }
        public string F3 { get; set; }
        public string F4 { get; set; }
        public System.DateTime? ConfirmIllDate { get; set; }
        public bool IsOps { get; set; }
        public bool IsBabyCard { get; set; }
        public bool IsMutiIll { get; set; }
        public int InfectTimes { get; set; }
        public bool IsSalvage { get; set; }
        public int SalvageTimes { get; set; }
        public bool IsSalvSucess { get; set; }
        public int SalvSucessTimes { get; set; }
        public bool IsFollow { get; set; }
        public System.DateTime? FollowEndDate { get; set; }
        public bool IsDeadBodyCheck { get; set; }
        public bool IsStudyCase { get; set; }
        public short LsQuality { get; set; }
        public int? ZrDoctorId { get; set; }
        public int? ZzDoctorId { get; set; }
        public int? ZyDoctorId { get; set; }
        public int? SxDoctorId { get; set; }
        public int? JxDoctorId { get; set; }
        public int? YjsDoctorId { get; set; }
        public int? ZkDoctorId { get; set; }
        public short LsAccMzIll { get; set; }
        public short LsAccZyIll { get; set; }
        public short LsAccOpsIll1 { get; set; }
        public short LsAccOpsIll2 { get; set; }
        public short LsAccOpsIll3 { get; set; }
        public short LsAccOpsIll4 { get; set; }
        public bool IsTjIll { get; set; }
        public bool IsConfirm3D { get; set; }
        public int BabyNum { get; set; }
        public bool IsTranNeact { get; set; }
        public bool IsOxygenNeact { get; set; }
        public bool IsMidFireBurn { get; set; }
        public bool IsSingleIll { get; set; }
        public bool IsHbsAg { get; set; }
        public bool IsHcvAb { get; set; }
        public bool IsHivAb { get; set; }
        public bool IsHbsAg3 { get; set; }
        public int? HeadOperId { get; set; }
        public int? ZkOperId { get; set; }
        public System.DateTime? ZkDate { get; set; }
        public bool IsRh { get; set; }
        public bool IsOpsFirst { get; set; }
        public bool IsCureFirst { get; set; }
        public bool IsCheckFirst { get; set; }
        public bool IsDiagFirst { get; set; }
        public int? RedCellNum { get; set; }
        public int? PlaqueNum { get; set; }
        public int? SerousNum { get; set; }
        public int? AllBloodNum { get; set; }
        public int? OtherBloodNum { get; set; }
        public int? ConsultHosputal { get; set; }
        public int? ConsultRemote { get; set; }
    }
}
