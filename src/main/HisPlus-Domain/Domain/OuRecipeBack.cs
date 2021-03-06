using System.Data.Entity.ModelConfiguration;
using HisPlus.Infrastructure.Contract.Messages;

namespace HisPlus.Domain
{
    public class OuRecipeBack : EntityBase<int>
    {
        public OuRecipeBack()
        {    
        }

        public int ReqDtlId { get; set; }
        public decimal Totality { get; set; }
        public int UnitId { get; set; }
        public System.DateTime OperTime { get; set; }
        public int OperId { get; set; }
        public int? DetailId { get; set; }
        public bool? IsCharged { get; set; }
    }
}
