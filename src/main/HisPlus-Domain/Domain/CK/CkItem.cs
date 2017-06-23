using AppPlus.Infrastructure.Contract.Messages;
using System.Data.Entity.ModelConfiguration;

namespace HisPlus.Domain
{
    public class CkItem : EntityBase<int>
    {
        public CkItem()
        {    
        }

        public string Code { get; set; }
        public short LsTestType { get; set; }
        public int? TestTypeId { get; set; }
        public int? TubeTypeId { get; set; }
        public string ShortName { get; set; }
        public string Name { get; set; }
        public string OperMemo { get; set; }
        public bool IsZero { get; set; }
        public short LsGroup { get; set; }
        public bool IsReport { get; set; }
        public string UseRange { get; set; }
        public short LsForSex { get; set; }
        public int? SourceId { get; set; }
        public decimal Price { get; set; }
        public string Unit { get; set; }
        public string Format { get; set; }
        public decimal LimitHigh { get; set; }
        public decimal LimitLow { get; set; }
        public string PrintHigh { get; set; }
        public string PrintLow { get; set; }
        public decimal DalAbsolute { get; set; }
        public decimal DalPercent { get; set; }
        public int? ItemId { get; set; }
        public short OrderBy { get; set; }
        public bool IsDisplay { get; set; }
        public bool IsActive { get; set; }
        public string F1 { get; set; }
        public string F2 { get; set; }
        public string F3 { get; set; }
        public string F4 { get; set; }
        public int? FluidId { get; set; }
        public string TestWay { get; set; }
        public decimal? Dev3 { get; set; }
        public decimal? Dev2 { get; set; }
        public decimal? Dev1 { get; set; }
        public decimal? DevM1 { get; set; }
        public decimal? DevM2 { get; set; }
        public decimal? DevM3 { get; set; }
        public decimal? AvgValue { get; set; }
        public string DefultValue { get; set; }
    }
}
