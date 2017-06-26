using System;
using System.Runtime.Serialization;
using AppPlus.Infrastructure.Contract.Messages;

namespace HisPlus.Contract.Messages
{
    [Serializable]
    [DataContract]
    public class RmstoreStockNum2DTO : DtoBase<System.DateTime>
    {
        public RmstoreStockNum2DTO()
        {
        }

        [DataMember]
        public decimal? StockNum { get; set; }
    }
}
