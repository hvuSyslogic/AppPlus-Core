using System;
using System.Runtime.Serialization;
using AppPlus.Infrastructure.Contract.Messages;

namespace HisPlus.Contract.Messages
{
    [Serializable]
    [DataContract]
    public class OuRecipeDTO : DtoBase<int>
    {
        public OuRecipeDTO()
        {
        }

        [DataMember]
        public int MzRegId { get; set; }

        [DataMember]
        public short LsRepType { get; set; }

        [DataMember]
        public string RecipeNum { get; set; }

        [DataMember]
        public System.DateTime RecipeTime { get; set; }

        [DataMember]
        public int LocationId { get; set; }

        [DataMember]
        public int DoctorId { get; set; }

        [DataMember]
        public short? HowMany { get; set; }

        [DataMember]
        public bool IsPriority { get; set; }

        [DataMember]
        public string Memo { get; set; }

        [DataMember]
        public bool IsPend { get; set; }

        [DataMember]
        public bool IsExecuted { get; set; }

        [DataMember]
        public int? PatId { get; set; }

        [DataMember]
        public bool? IsDosage { get; set; }

        [DataMember]
        public int? DosageOperId { get; set; }

        [DataMember]
        public System.DateTime? DosageTime { get; set; }

        [DataMember]
        public int? HospitalId { get; set; }
    }
}
