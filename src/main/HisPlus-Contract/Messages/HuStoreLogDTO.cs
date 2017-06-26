using System;
using System.Runtime.Serialization;
using AppPlus.Infrastructure.Contract.Messages;

namespace HisPlus.Contract.Messages
{
    [Serializable]
    [DataContract]
    public class HuStoreLogDTO : DtoBase<int>
    {
        public HuStoreLogDTO()
        {
        }

        [DataMember]
        public System.DateTime HappenTime { get; set; }

        [DataMember]
        public int HouseId { get; set; }

        [DataMember]
        public int ItemId { get; set; }

        [DataMember]
        public int InBatchId { get; set; }

        [DataMember]
        public decimal BeforeStockNum { get; set; }

        [DataMember]
        public decimal HappenNum { get; set; }

        [DataMember]
        public decimal AfterStockNum { get; set; }

        [DataMember]
        public decimal RetailPrice { get; set; }

        [DataMember]
        public decimal StockPrice { get; set; }

        [DataMember]
        public int UnitId { get; set; }

        [DataMember]
        public string BillNo { get; set; }

        [DataMember]
        public short LsActType { get; set; }

        [DataMember]
        public string Memo { get; set; }

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
