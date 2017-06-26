using System;
using System.Runtime.Serialization;
using AppPlus.Infrastructure.Contract.Messages;

namespace HisPlus.Contract.Messages
{
    [Serializable]
    [DataContract]
    public class CsDeptIncomeDTO : DtoBase<int>
    {
        public CsDeptIncomeDTO()
        {
        }

        [DataMember]
        public string YearMonth { get; set; }

        [DataMember]
        public int? FeeHsId { get; set; }

        [DataMember]
        public int OperLocId { get; set; }

        [DataMember]
        public int ExcLocId { get; set; }

        [DataMember]
        public decimal Amount { get; set; }

        [DataMember]
        public int? OperId { get; set; }

        [DataMember]
        public System.DateTime? OperTime { get; set; }

        [DataMember]
        public string Abstract { get; set; }

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
