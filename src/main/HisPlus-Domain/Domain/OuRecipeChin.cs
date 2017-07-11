using System.Data.Entity.ModelConfiguration;
using HisPlus.Infrastructure.Contract.Messages;

namespace HisPlus.Domain
{
    public class OuRecipeChin : EntityBase<int>
    {
        public OuRecipeChin()
        {    
        }

        public int RecipeId { get; set; }
        public int? FrequencyId { get; set; }
        public int? UsageId { get; set; }
        public short DecoctNum { get; set; }
        public short LsCookSelf { get; set; }
        public short? CookMinute { get; set; }
        public short? LsFire { get; set; }
    }
}
