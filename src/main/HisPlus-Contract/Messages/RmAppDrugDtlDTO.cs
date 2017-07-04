using System;
using System.Runtime.Serialization;
using AppPlus.Infrastructure.Contract.Messages;

namespace HisPlus.Contract.Messages
{
    [Serializable]
    [DataContract]
    public class RmAppDrugDtlDTO : DtoBase<int>
    {
        public RmAppDrugDtlDTO()
        {
        }

        [DataMember]
        public int BillId { get; set; }

        [DataMember]
        public int ItemId { get; set; }

        [DataMember]
        public decimal DrugNum { get; set; }

        [DataMember]
        public int UnitId { get; set; }

        [DataMember]
        public decimal? HuStockNum { get; set; }

        [DataMember]
        public int? UnitKc { get; set; }

        [DataMember]
        public string Pno { get; set; }

        [DataMember]
        public System.DateTime? LimitDate { get; set; }
    }
}
