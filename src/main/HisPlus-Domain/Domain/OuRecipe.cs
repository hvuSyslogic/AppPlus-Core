using System.Data.Entity.ModelConfiguration;
using HisPlus.Infrastructure.Contract.Messages;

namespace HisPlus.Domain
{
    public class OuRecipe : EntityBase<int>
    {
        public OuRecipe()
        {    
        }

        public int MzRegId { get; set; }
        public short LsRepType { get; set; }
        public string RecipeNum { get; set; }
        public System.DateTime RecipeTime { get; set; }
        public int LocationId { get; set; }
        public int DoctorId { get; set; }
        public short? HowMany { get; set; }
        public bool IsPriority { get; set; }
        public string Memo { get; set; }
        public bool IsPend { get; set; }
        public bool IsExecuted { get; set; }
        public int? PatId { get; set; }
        public bool? IsDosage { get; set; }
        public int? DosageOperId { get; set; }
        public System.DateTime? DosageTime { get; set; }
        public int? HospitalId { get; set; }
    }
}
