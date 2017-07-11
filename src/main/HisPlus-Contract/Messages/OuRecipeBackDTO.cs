using System;
using System.Runtime.Serialization;
using HisPlus.Infrastructure.Contract.Messages;

namespace HisPlus.Contract.Messages
{
    [Serializable]
    [DataContract]
    public class OuRecipeBackDTO : DtoBase<int>
    {
        public OuRecipeBackDTO()
        {
        }

        [DataMember]
        public int ReqDtlId { get; set; }

        [DataMember]
        public decimal Totality { get; set; }

        [DataMember]
        public int UnitId { get; set; }

        [DataMember]
        public System.DateTime OperTime { get; set; }

        [DataMember]
        public int OperId { get; set; }

        [DataMember]
        public int? DetailId { get; set; }

        [DataMember]
        public bool? IsCharged { get; set; }
    }
}
