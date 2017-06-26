using AppPlus.Infrastructure.Contract.Messages;
using System.Data.Entity.ModelConfiguration;

namespace HisPlus.Domain
{
    // The table 'mdc_drug_match_result' is not usable by entity framework because it
    // does not have a primary key. It is listed here for completeness.
    public class MdcDrugMatchResult
    {
        public MdcDrugMatchResult()
        {    
        }

        public string SuserId { get; set; }
        public string SuserUnit { get; set; }
        public string SsysName { get; set; }
        public string SsysType { get; set; }
        public string Sstrength { get; set; }
        public string SsysUnit { get; set; }
        public string Sunitrate { get; set; }
        public string SmatchUser { get; set; }
        public string SmatchTime { get; set; }
        public string ShasHisInfo { get; set; }
    }
}
