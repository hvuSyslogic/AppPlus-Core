using System;
using System.Runtime.Serialization;
using AppPlus.Infrastructure.Contract.Messages;

namespace HisPlus.Contract.Messages
{
    [Serializable]
    [DataContract]
    public class OuRecipeChinDTO : DtoBase<int>
    {
        public OuRecipeChinDTO()
        {
        }

        [DataMember]
        public int RecipeId { get; set; }

        [DataMember]
        public int? FrequencyId { get; set; }

        [DataMember]
        public int? UsageId { get; set; }

        [DataMember]
        public short DecoctNum { get; set; }

        [DataMember]
        public short LsCookSelf { get; set; }

        [DataMember]
        public short? CookMinute { get; set; }

        [DataMember]
        public short? LsFire { get; set; }
    }
}
