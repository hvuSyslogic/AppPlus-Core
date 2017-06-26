using System;
using System.Runtime.Serialization;
using AppPlus.Infrastructure.Contract.Messages;

namespace HisPlus.Contract.Messages
{
    [Serializable]
    [DataContract]
    public class DhStoreDTO : DtoBase<int>
    {
        public DhStoreDTO()
        {
        }

        [DataMember]
        public int? HospitalId { get; set; }

        [DataMember]
        public string InBatchNo { get; set; }

        [DataMember]
        public string ItemCode { get; set; }

        [DataMember]
        public string ItemName { get; set; }

        [DataMember]
        public int UnitId { get; set; }

        [DataMember]
        public int UnitKcId { get; set; }

        [DataMember]
        public int? CompId { get; set; }

        [DataMember]
        public int? ManuId { get; set; }

        [DataMember]
        public int FormId { get; set; }

        [DataMember]
        public bool IsRecipe { get; set; }

        [DataMember]
        public bool IsPoison { get; set; }

        [DataMember]
        public bool IsMental { get; set; }

        [DataMember]
        public bool IsExpen { get; set; }

        [DataMember]
        public bool IsSelf { get; set; }

        [DataMember]
        public short LsImport { get; set; }

        [DataMember]
        public bool IsCountry { get; set; }

        [DataMember]
        public bool IsProvince { get; set; }

        [DataMember]
        public bool IsBid { get; set; }

        [DataMember]
        public string PassNo { get; set; }

        [DataMember]
        public decimal StockNum { get; set; }

        [DataMember]
        public decimal StockPrice { get; set; }

        [DataMember]
        public decimal RetailPrice { get; set; }

        [DataMember]
        public System.DateTime StoreDate { get; set; }

        [DataMember]
        public System.DateTime? ProduceDate { get; set; }

        [DataMember]
        public System.DateTime? LimitDate { get; set; }

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
