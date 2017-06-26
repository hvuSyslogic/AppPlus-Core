using System;
using System.Runtime.Serialization;
using AppPlus.Infrastructure.Contract.Messages;

namespace HisPlus.Contract.Messages
{
    [Serializable]
    [DataContract]
    public class InChinRicipeDtlDTO : DtoBase<int>
    {
        public InChinRicipeDtlDTO()
        {
        }

        [DataMember]
        public int RecipeId { get; set; }

        [DataMember]
        public int ItemId { get; set; }

        [DataMember]
        public decimal Dosage { get; set; }

        [DataMember]
        public int UnitTakeId { get; set; }

        [DataMember]
        public short LsDecoctWay { get; set; }

        [DataMember]
        public string Memo { get; set; }

        [DataMember]
        public int OperId { get; set; }

        [DataMember]
        public System.DateTime OperTime { get; set; }

        [DataMember]
        public int? DetailId { get; set; }

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
