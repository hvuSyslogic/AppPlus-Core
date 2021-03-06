using System;
using System.Runtime.Serialization;
using HisPlus.Infrastructure.Contract.Messages;

namespace HisPlus.Contract.Messages
{
    [Serializable]
    [DataContract]
    public class RmAdjustDtlDTO : DtoBase<int>
    {
        public RmAdjustDtlDTO()
        {
        }

        [DataMember]
        public int BillId { get; set; }

        [DataMember]
        public int RoomId { get; set; }

        [DataMember]
        public int InBatchId { get; set; }

        [DataMember]
        public int ItemId { get; set; }

        [DataMember]
        public decimal DrugNum { get; set; }

        [DataMember]
        public decimal NewPrice { get; set; }

        [DataMember]
        public decimal OldPrice { get; set; }

        [DataMember]
        public decimal ProfLoss { get; set; }
    }
}
