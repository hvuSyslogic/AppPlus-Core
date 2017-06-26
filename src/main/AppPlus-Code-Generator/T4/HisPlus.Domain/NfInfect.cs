using System.Data.Entity.ModelConfiguration;
using AppPlus.Infrastructure.Contract.Messages;

namespace HisPlus.Domain
{
    public class NfInfect : EntityBase<int>
    {
        public NfInfect()
        {    
        }

        public short LsInfectType { get; set; }
        public string Code { get; set; }
        public int HospId { get; set; }
        public short LsEffect { get; set; }
        public short LsCutType { get; set; }
        public System.DateTime InfectTime { get; set; }
        public System.DateTime OperTime { get; set; }
        public int OperId { get; set; }
        public int PositionId { get; set; }
        public int LocationId { get; set; }
        public int SpecialityId { get; set; }
        public short? LsInfluence { get; set; }
        public string F1 { get; set; }
        public string F2 { get; set; }
        public string F3 { get; set; }
        public string F4 { get; set; }
        public int? OpsId { get; set; }
        public System.DateTime? OpsTime { get; set; }
        public short? LsClass { get; set; }
        public short? LsAsa { get; set; }
        public bool? IsEmergency { get; set; }
        public int? AnaesId { get; set; }
        public int? Minutes { get; set; }
        public bool? IsImplant { get; set; }
        public bool? IsImglass { get; set; }
        public bool? IsOpsDrug { get; set; }
        public bool? IsUseDrug { get; set; }
        public short? LsInfectRange { get; set; }
        public short? LsUseType { get; set; }
        public short? LsUnionDrug { get; set; }
        public short? LsUsePurpose { get; set; }
        public int? DoctorId { get; set; }
    }
}
