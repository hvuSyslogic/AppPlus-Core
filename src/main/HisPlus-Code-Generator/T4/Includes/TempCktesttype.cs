using AppPlus.Infrastructure.Contract.Messages;
using System.Data.Entity.ModelConfiguration;

namespace HisPlus.Domain
{
    // The table 'temp_cktesttype' is not usable by entity framework because it
    // does not have a primary key. It is listed here for completeness.
    public class TempCktesttype
    {
        public TempCktesttype()
        {    
        }

        public string Code { get; set; }
        public string Name { get; set; }
        public double? Testgroupid { get; set; }
        public double? IsLab { get; set; }
        public string Pycode { get; set; }
        public string Wbcode { get; set; }
        public double? Orderby { get; set; }
        public double? Isactive { get; set; }
        public string F1 { get; set; }
        public string F2 { get; set; }
        public string F3 { get; set; }
        public string F4 { get; set; }
        public double? Iconindex { get; set; }
    }
}
