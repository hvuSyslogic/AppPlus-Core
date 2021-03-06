using AppPlus.Infrastructure.Contract.Messages;
using System.Data.Entity.ModelConfiguration;

namespace HisPlus.Domain
{
    public class DhOuRecipeDtl : EntityBase<int>
    {
        public DhOuRecipeDtl()
        {    
        }

        public int RecipeId { get; set; }
        public int ListNum { get; set; }
        public string ItemCode { get; set; }
        public string ItemName { get; set; }
        public short? GroupNum { get; set; }
        public string DrugName { get; set; }
        public string Spec { get; set; }
        public string FormName { get; set; }
        public decimal? PriceIn { get; set; }
        public decimal? Dosage { get; set; }
        public int? UnitTakeId { get; set; }
        public int? FrequencyId { get; set; }
        public int? UsageId { get; set; }
        public short? Days { get; set; }
        public decimal? Totality { get; set; }
        public int? UnitDiagId { get; set; }
        public bool? IsAttach { get; set; }
        public bool? IsSelf { get; set; }
        public bool? IsSkin { get; set; }
        public System.DateTime? SkinTime { get; set; }
        public string SkinTest { get; set; }
        public string Memo { get; set; }
        public System.DateTime OperTime { get; set; }
        public string OperName { get; set; }
        public System.DateTime? AuthTime { get; set; }
        public string AuthName { get; set; }
        public bool? IsExec { get; set; }
        public System.DateTime? ExecTime { get; set; }
        public string ExecOperName { get; set; }
        public decimal? Amount { get; set; }
        public string F1 { get; set; }
        public string F2 { get; set; }
        public string F3 { get; set; }
        public string F4 { get; set; }
    }
}
