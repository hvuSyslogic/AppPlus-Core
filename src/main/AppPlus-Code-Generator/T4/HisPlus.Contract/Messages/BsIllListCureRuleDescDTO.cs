using AppPlus.Infrastructure.Contract.Messages;

namespace HisPlus.Contract.Messages
{
    // The table 'BsIllListCureRuleDesc' is not usable by entity framework because it
    // does not have a primary key. It is listed here for completeness.
    public class BsIllListCureRuleDescDTO
    {
        public BsIllListCureRuleDescDTO()
        {
        }

        public string 疾病 { get; set; }
        public string 患者分组 { get; set; }
        public string 治疗原则 { get; set; }
        public string 小字说明 { get; set; }
        public int? 排序 { get; set; }
        public int? 分组排序 { get; set; }
        public System.DateTime? ImpTime { get; set; }
        public int? BpIllId { get; set; }
        public int? BpGroupId { get; set; }
    }
}
