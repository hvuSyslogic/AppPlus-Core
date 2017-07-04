using System.Data.Entity.ModelConfiguration;
using AppPlus.Infrastructure.Contract.Messages;

namespace HisPlus.Domain
{
    public class BsBpCure : EntityBase<int>
    {
        public BsBpCure()
        {    
        }

        public string CureRuleName { get; set; }
        public string CureRuleDesc { get; set; }
        public int? BpIllId { get; set; }
        public int? BpGroupId { get; set; }
        public int? OrderBy { get; set; }
    }
}
