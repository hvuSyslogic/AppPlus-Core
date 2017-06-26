using System;
using System.Runtime.Serialization;
using AppPlus.Infrastructure.Contract.Messages;

namespace HisPlus.Contract.Messages
{
    [Serializable]
    [DataContract]
    public class DhOuRecipeDTO : DtoBase<int>
    {
        public DhOuRecipeDTO()
        {
        }

        [DataMember]
        public int? HospitalId { get; set; }

        [DataMember]
        public int? RecId { get; set; }

        [DataMember]
        public string MzRegNo { get; set; }

        [DataMember]
        public System.DateTime RegTime { get; set; }

        [DataMember]
        public int PatId { get; set; }

        [DataMember]
        public string CardNo { get; set; }

        [DataMember]
        public string Name { get; set; }

        [DataMember]
        public string Sex { get; set; }

        [DataMember]
        public string Illness { get; set; }

        [DataMember]
        public string MedicareNo { get; set; }

        [DataMember]
        public string PatTypeName { get; set; }

        [DataMember]
        public string RegTypeName { get; set; }

        [DataMember]
        public string DiagnDeptName { get; set; }

        [DataMember]
        public string DoctorName { get; set; }

        [DataMember]
        public string DoctorCode { get; set; }

        [DataMember]
        public string DocLevel { get; set; }

        [DataMember]
        public string RoomNo { get; set; }

        [DataMember]
        public short? LsRepType { get; set; }

        [DataMember]
        public string RecipeNum { get; set; }

        [DataMember]
        public System.DateTime? RecipeTime { get; set; }

        [DataMember]
        public short? HowMany { get; set; }

        [DataMember]
        public bool? IsPriority { get; set; }

        [DataMember]
        public decimal? Amount { get; set; }

        [DataMember]
        public string Memo { get; set; }

        [DataMember]
        public string F1 { get; set; }

        [DataMember]
        public string F2 { get; set; }

        [DataMember]
        public string F3 { get; set; }

        [DataMember]
        public string F4 { get; set; }

        [DataMember]
        public string IcdCode { get; set; }
    }
}
