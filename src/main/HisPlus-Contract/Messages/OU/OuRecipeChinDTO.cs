using AppPlus.Infrastructure.Contract.Messages;

namespace HisPlus.Contract.Messages
{
    public class OuRecipeChinDTO : DtoBase<int>
    {
        public OuRecipeChinDTO()
        {
        }

        public int RecipeId { get; set; }
        public int? FrequencyId { get; set; }
        public int? UsageId { get; set; }
        public short DecoctNum { get; set; }
        public short LsCookSelf { get; set; }
        public short? CookMinute { get; set; }
        public short? LsFire { get; set; }
        public string F1 { get; set; }
        public string F2 { get; set; }
        public string F3 { get; set; }
        public string F4 { get; set; }
    }
}
