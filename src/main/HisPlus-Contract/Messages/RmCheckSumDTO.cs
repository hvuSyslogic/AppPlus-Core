using System;
using System.Runtime.Serialization;
using AppPlus.Infrastructure.Contract.Messages;

namespace HisPlus.Contract.Messages
{
    [Serializable]
    [DataContract]
    public class RmCheckSumDTO : DtoBase<int>
    {
        public RmCheckSumDTO()
        {
        }

        [DataMember]
        public int CheckId { get; set; }

        [DataMember]
        public string SumFor { get; set; }

        [DataMember]
        public decimal ApplyIn { get; set; }

        [DataMember]
        public decimal MzBackIn { get; set; }

        [DataMember]
        public decimal ZyBackIn { get; set; }

        [DataMember]
        public decimal PyIn { get; set; }

        [DataMember]
        public decimal MoveIn { get; set; }

        [DataMember]
        public decimal OtherIn { get; set; }

        [DataMember]
        public decimal MoveOut { get; set; }

        [DataMember]
        public decimal MzOut { get; set; }

        [DataMember]
        public decimal ZyOut { get; set; }

        [DataMember]
        public decimal PkOut { get; set; }

        [DataMember]
        public decimal LoseOut { get; set; }

        [DataMember]
        public decimal BackOut { get; set; }

        [DataMember]
        public decimal OtherOut { get; set; }

        [DataMember]
        public decimal AdjustAmouUp { get; set; }

        [DataMember]
        public decimal AdjustAmouDn { get; set; }

        [DataMember]
        public decimal CheckAmou { get; set; }

        [DataMember]
        public decimal BalanceAmou { get; set; }

        [DataMember]
        public decimal RecipeOut { get; set; }

        [DataMember]
        public decimal KsBackIn { get; set; }

        [DataMember]
        public decimal KsOut { get; set; }

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
