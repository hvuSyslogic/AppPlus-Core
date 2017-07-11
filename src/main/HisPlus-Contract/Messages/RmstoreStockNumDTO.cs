using System;
using System.Runtime.Serialization;
using HisPlus.Infrastructure.Contract.Messages;

namespace HisPlus.Contract.Messages
{
    [Serializable]
    [DataContract]
    public class RmstoreStockNumDTO : DtoBase<System.DateTime>
    {
        public RmstoreStockNumDTO()
        {
        }

        [DataMember]
        public decimal? StockNum { get; set; }
    }
}
