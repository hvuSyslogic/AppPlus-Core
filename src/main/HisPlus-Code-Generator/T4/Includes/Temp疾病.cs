using AppPlus.Infrastructure.Contract.Messages;
using System.Data.Entity.ModelConfiguration;

namespace HisPlus.Domain
{
    // The table 'temp疾病' is not usable by entity framework because it
    // does not have a primary key. It is listed here for completeness.
    public class Temp疾病
    {
        public Temp疾病()
        {    
        }

        public string Name { get; set; }
        public string Wbcode { get; set; }
        public string Pycode { get; set; }
        public double? Orderby { get; set; }
    }
}
