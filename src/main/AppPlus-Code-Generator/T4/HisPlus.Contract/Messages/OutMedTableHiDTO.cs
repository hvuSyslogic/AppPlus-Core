using System;
using System.Runtime.Serialization;
using AppPlus.Infrastructure.Contract.Messages;

namespace HisPlus.Contract.Messages
{
    [Serializable]
    [DataContract]
    public class OutMedTableHiDTO : DtoBase<int>
    {
        public OutMedTableHiDTO()
        {
        }

        [DataMember]
        public string PresNo { get; set; }

        [DataMember]
        public int MedId { get; set; }

        [DataMember]
        public string MedOnlyCode { get; set; }

        [DataMember]
        public int MedAmt { get; set; }

        [DataMember]
        public string MedPack { get; set; }

        [DataMember]
        public string MedUnitPack { get; set; }

        [DataMember]
        public string MedUnit { get; set; }

        [DataMember]
        public System.DateTime MedOutTime { get; set; }

        [DataMember]
        public string PresType { get; set; }

        [DataMember]
        public int WindowNo { get; set; }

        [DataMember]
        public string PatientId { get; set; }

        [DataMember]
        public string PatientName { get; set; }

        [DataMember]
        public string PatientSex { get; set; }

        [DataMember]
        public string PatientAge { get; set; }

        [DataMember]
        public string PatientBirth { get; set; }

        [DataMember]
        public string Diagnosis { get; set; }

        [DataMember]
        public string WardNo { get; set; }

        [DataMember]
        public string WardName { get; set; }

        [DataMember]
        public string MedPerdos { get; set; }

        [DataMember]
        public string MedUsage { get; set; }

        [DataMember]
        public string MedPerday { get; set; }

        [DataMember]
        public string DoctorName { get; set; }

        [DataMember]
        public string Fpno { get; set; }

        [DataMember]
        public string SEndflag { get; set; }

        [DataMember]
        public decimal? MedUnitPrice { get; set; }

        [DataMember]
        public decimal? MedTotalPrice { get; set; }

        [DataMember]
        public string MedType { get; set; }

        [DataMember]
        public int? MedConvercof { get; set; }

        [DataMember]
        public string Remark { get; set; }

        [DataMember]
        public string YfCode { get; set; }

        [DataMember]
        public string Endflag { get; set; }

        [DataMember]
        public string YfFinish { get; set; }
    }
}
