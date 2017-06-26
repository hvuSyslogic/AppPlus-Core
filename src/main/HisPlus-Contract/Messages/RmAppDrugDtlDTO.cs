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
        public string F1 { get; set; }

        [DataMember]
        public string F2 { get; set; }

        [DataMember]
        public string F3 { get; set; }

        [DataMember]
        public string F4 { get; set; }
    }
}
