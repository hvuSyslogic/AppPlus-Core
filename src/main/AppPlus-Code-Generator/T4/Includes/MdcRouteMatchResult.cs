using AppPlus.Infrastructure.Contract.Messages;
using System.Data.Entity.ModelConfiguration;

namespace HisPlus.Domain
{
    // The table 'mdc_route_match_result' is not usable by entity framework because it
    // does not have a primary key. It is listed here for completeness.
    public class MdcRouteMatchResult
    {
        public MdcRouteMatchResult()
        {    
        }

        public string SuserId { get; set; }
        public string SsysName { get; set; }
        public string SmatchUser { get; set; }
        public string SmatchTime { get; set; }
    }
}
