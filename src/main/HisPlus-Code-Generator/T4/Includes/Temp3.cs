using AppPlus.Infrastructure.Contract.Messages;
using System.Data.Entity.ModelConfiguration;

namespace HisPlus.Domain
{
    // The table 'temp3' is not usable by entity framework because it
    // does not have a primary key. It is listed here for completeness.
    public class Temp3
    {
        public Temp3()
        {    
        }

        public double? 编码 { get; set; }
        public double? 省统一编码1 { get; set; }
        public string 省统一编码 { get; set; }
        public string 项目名称 { get; set; }
        public string 处方类别 { get; set; }
        public double? 价格47元40二级41 { get; set; }
        public string 单位 { get; set; }
        public double? 自付 { get; set; }
        public double? 保险支付 { get; set; }
        public string 执行科室 { get; set; }
        public string 发票分类 { get; set; }
        public string 门诊核算分类 { get; set; }
        public string 住院核算分类 { get; set; }
        public string 医保费用分类 { get; set; }
        public string 一级分类 { get; set; }
        public double? 医保编码1 { get; set; }
        public string 医保编码 { get; set; }
        public string 是否按小时收费 { get; set; }
        public string 是否可用 { get; set; }
        public string 是否有影像申请 { get; set; }
        public string 助记码 { get; set; }
    }
}
