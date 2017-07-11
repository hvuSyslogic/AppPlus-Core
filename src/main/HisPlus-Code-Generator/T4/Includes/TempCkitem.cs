using AppPlus.Infrastructure.Contract.Messages;
using System.Data.Entity.ModelConfiguration;

namespace HisPlus.Domain
{
    // The table 'temp_ckitem' is not usable by entity framework because it
    // does not have a primary key. It is listed here for completeness.
    public class TempCkitem
    {
        public TempCkitem()
        {    
        }

        public string 分类 { get; set; }
        public string 容器类型 { get; set; }
        public string 标本来源 { get; set; }
        public string 标本类型 { get; set; }
        public string 编码 { get; set; }
        public string 项目名称 { get; set; }
        public string 组集 { get; set; }
        public double? 价格 { get; set; }
        public string 备注 { get; set; }
        public string Code { get; set; }
        public double? Lstesttype { get; set; }
        public double? Testtypeid { get; set; }
        public double? Tubetypeid { get; set; }
        public string Shortname { get; set; }
        public string Name { get; set; }
        public string Opermemo { get; set; }
        public double? Iszero { get; set; }
        public double? Lsgroup { get; set; }
        public double? Isreport { get; set; }
        public string Userange { get; set; }
        public double? Lsforsex { get; set; }
        public double? Sourceid { get; set; }
        public double? Price { get; set; }
        public string Unit { get; set; }
        public string Format { get; set; }
        public double? Limithigh { get; set; }
        public double? Limitlow { get; set; }
        public string Printhigh { get; set; }
        public string Printlow { get; set; }
        public double? Dalabsolute { get; set; }
        public double? Dalpercent { get; set; }
        public double? Itemid { get; set; }
        public double? Orderby { get; set; }
        public double? Isdisplay { get; set; }
        public double? Isactive { get; set; }
        public string F1 { get; set; }
        public string F2 { get; set; }
        public string F3 { get; set; }
        public string F4 { get; set; }
        public string Fluidid { get; set; }
        public string Testway { get; set; }
        public double? Dev3 { get; set; }
        public double? Dev2 { get; set; }
        public double? Dev1 { get; set; }
        public double? Devm1 { get; set; }
        public double? Devm2 { get; set; }
        public double? Devm3 { get; set; }
        public double? Avgvalue { get; set; }
        public string Defultvalue { get; set; }
        public string Wbcode { get; set; }
        public string Pycode { get; set; }
    }
}
