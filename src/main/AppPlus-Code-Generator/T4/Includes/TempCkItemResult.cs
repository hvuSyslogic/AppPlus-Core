using AppPlus.Infrastructure.Contract.Messages;
using System.Data.Entity.ModelConfiguration;

namespace HisPlus.Domain
{
    // The table 'temp_CkItemResult' is not usable by entity framework because it
    // does not have a primary key. It is listed here for completeness.
    public class TempCkItemResult
    {
        public TempCkItemResult()
        {    
        }

        public double? Testid { get; set; }
        public string Result { get; set; }
        public double? Isbold { get; set; }
        public double? Ispass { get; set; }
        public string F1 { get; set; }
        public string F2 { get; set; }
        public string F3 { get; set; }
        public string F4 { get; set; }
        public string Summary { get; set; }
        public string Doctoradvice { get; set; }
    }
}
