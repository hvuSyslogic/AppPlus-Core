using AppPlus.Infrastructure.Contract.Messages;
using System.Data.Entity.ModelConfiguration;

namespace HisPlus.Domain
{
    // The table 'inemrxml_temp' is not usable by entity framework because it
    // does not have a primary key. It is listed here for completeness.
    public class InemrxmlTemp
    {
        public InemrxmlTemp()
        {    
        }

        public string Mouth { get; set; }
        public string Xmlfield { get; set; }
        public int? Rc { get; set; }
    }
}
