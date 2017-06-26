using System;
using System.Runtime.Serialization;
using AppPlus.Infrastructure.Contract.Messages;

namespace HisPlus.Contract.Messages
{
    [Serializable]
    [DataContract]
    public class DhInAdviceLongDTO : DtoBase<int>
    {
        public DhInAdviceLongDTO()
        {
        }

        [DataMember]
        public int? HospitalId { get; set; }

        [DataMember]
        public int? RecId { get; set; }

        [DataMember]
        public int PatId { get; set; }

        [DataMember]
        public string InPatNo { get; set; }

        [DataMember]
        public System.DateTime AdviceTime { get; set; }

        [DataMember]
        public string DiagnDeptName { get; set; }

        [DataMember]
        public string DoctorName { get; set; }

        [DataMember]
        public int ListNum { get; set; }

        [DataMember]
        public string ItemCode { get; set; }

        [DataMember]
        public string ItemName { get; set; }

        [DataMember]
        public string DrugName { get; set; }

        [DataMember]
        public string Spec { get; set; }

        [DataMember]
        public decimal PriceIn { get; set; }

        [DataMember]
        public short? GroupNum { get; set; }

        [DataMember]
        public decimal? Dosage { get; set; }

        [DataMember]
        public int? UnitTakeId { get; set; }

        [DataMember]
        public int? FrequencyId { get; set; }

        [DataMember]
        public int? UsageId { get; set; }

        [DataMember]
        public short? Days { get; set; }

        [DataMember]
        public decimal? Totality { get; set; }

        [DataMember]
        public int? UnitDiagId { get; set; }

        [DataMember]
        public short? FirstDay { get; set; }

        [DataMember]
        public short? LastDay { get; set; }

        [DataMember]
        public bool? IsAttach { get; set; }

        [DataMember]
        public bool? IsSelf { get; set; }

        [DataMember]
        public bool? IsSkin { get; set; }

        [DataMember]
        public System.DateTime? SkinTime { get; set; }

        [DataMember]
        public string SkinTest { get; set; }

        [DataMember]
        public string Memo { get; set; }

        [DataMember]
        public System.DateTime OperTime { get; set; }

        [DataMember]
        public string OperName { get; set; }

        [DataMember]
        public System.DateTime? AuthTime { get; set; }

        [DataMember]
        public string AuthName { get; set; }

        [DataMember]
        public bool? IsExec { get; set; }

        [DataMember]
        public System.DateTime? ExecTime { get; set; }

        [DataMember]
        public string ExecOperName { get; set; }

        [DataMember]
        public decimal? Amount { get; set; }

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
