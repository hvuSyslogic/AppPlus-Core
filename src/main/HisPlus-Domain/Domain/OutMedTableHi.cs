using System.Data.Entity.ModelConfiguration;
using HisPlus.Infrastructure.Contract.Messages;

namespace HisPlus.Domain
{
    public class OutMedTableHi : EntityBase<int>
    {
        public OutMedTableHi()
        {    
        }

        public string PresNo { get; set; }
        public int MedId { get; set; }
        public string MedOnlyCode { get; set; }
        public int MedAmt { get; set; }
        public string MedPack { get; set; }
        public string MedUnitPack { get; set; }
        public string MedUnit { get; set; }
        public System.DateTime MedOutTime { get; set; }
        public string PresType { get; set; }
        public int WindowNo { get; set; }
        public string PatientId { get; set; }
        public string PatientName { get; set; }
        public string PatientSex { get; set; }
        public string PatientAge { get; set; }
        public string PatientBirth { get; set; }
        public string Diagnosis { get; set; }
        public string WardNo { get; set; }
        public string WardName { get; set; }
        public string MedPerdos { get; set; }
        public string MedUsage { get; set; }
        public string MedPerday { get; set; }
        public string DoctorName { get; set; }
        public string Fpno { get; set; }
        public string SEndflag { get; set; }
        public decimal? MedUnitPrice { get; set; }
        public decimal? MedTotalPrice { get; set; }
        public string MedType { get; set; }
        public int? MedConvercof { get; set; }
        public string Remark { get; set; }
        public string YfCode { get; set; }
        public string Endflag { get; set; }
        public string YfFinish { get; set; }
    }
}
