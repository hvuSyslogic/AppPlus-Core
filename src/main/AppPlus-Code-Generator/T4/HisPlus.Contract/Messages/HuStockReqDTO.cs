using System;
using System.Runtime.Serialization;
using AppPlus.Infrastructure.Contract.Messages;

namespace HisPlus.Contract.Messages
{
    [Serializable]
    [DataContract]
    public class HuStockReqDTO : DtoBase<int>
    {
        public HuStockReqDTO()
        {
        }

        [DataMember]
        public string BillNo { get; set; }

        [DataMember]
        public int HouseId { get; set; }

        [DataMember]
        public System.DateTime ApplyTime { get; set; }

        [DataMember]
        public System.DateTime? ValideTime { get; set; }

        [DataMember]
        public string ApplyIdea { get; set; }

        [DataMember]
        public string ApplyHander { get; set; }

        [DataMember]
        public int OperId { get; set; }

        [DataMember]
        public System.DateTime OperTime { get; set; }

        [DataMember]
        public int? CompId { get; set; }
    }
}
