using AppPlus.Infrastructure.Contract.Messages;
using System.Data.Entity.ModelConfiguration;

namespace HisPlus.Domain
{
    public class DhStore : EntityBase<int>
    {
        public DhStore()
        {    
        }

        public int? HospitalId { get; set; }
        public string InBatchNo { get; set; }
        public string ItemCode { get; set; }
        public string ItemName { get; set; }
        public int UnitId { get; set; }
        public int UnitKcId { get; set; }
        public int? CompId { get; set; }
        public int? ManuId { get; set; }
        public int FormId { get; set; }
        public bool IsRecipe { get; set; }
        public bool IsPoison { get; set; }
        public bool IsMental { get; set; }
        public bool IsExpen { get; set; }
        public bool IsSelf { get; set; }
        public short LsImport { get; set; }
        public bool IsCountry { get; set; }
        public bool IsProvince { get; set; }
        public bool IsBid { get; set; }
        public string PassNo { get; set; }
        public decimal StockNum { get; set; }
        public decimal StockPrice { get; set; }
        public decimal RetailPrice { get; set; }
        public System.DateTime StoreDate { get; set; }
        public System.DateTime? ProduceDate { get; set; }
        public System.DateTime? LimitDate { get; set; }
        public string F1 { get; set; }
        public string F2 { get; set; }
        public string F3 { get; set; }
        public string F4 { get; set; }
    }
}
