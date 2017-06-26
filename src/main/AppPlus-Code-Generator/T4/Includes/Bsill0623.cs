using AppPlus.Infrastructure.Contract.Messages;
using System.Data.Entity.ModelConfiguration;

namespace HisPlus.Domain
{
    // The table 'bsill0623' is not usable by entity framework because it
    // does not have a primary key. It is listed here for completeness.
    public class Bsill0623
    {
        public Bsill0623()
        {    
        }

        public string Name { get; set; }
        public string Patientgroup { get; set; }
        public string Treatment { get; set; }
        public string Detail { get; set; }
        public double? Orderby { get; set; }
        public double? Treatorderby { get; set; }
    }
}
