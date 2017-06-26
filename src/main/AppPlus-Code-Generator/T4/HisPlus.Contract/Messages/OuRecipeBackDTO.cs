using System;
using System.Runtime.Serialization;
using AppPlus.Infrastructure.Contract.Messages;

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
