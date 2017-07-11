using AppPlus.Infrastructure.Contract.Messages;
using System.Data.Entity.ModelConfiguration;

namespace HisPlus.Domain
{
    // The table 'temp_CkItemRange' is not usable by entity framework because it
    // does not have a primary key. It is listed here for completeness.
    public class TempCkItemRange
    {
        public TempCkItemRange()
        {    
        }

        public double? Testid { get; set; }
        public string Sex { get; set; }
        public double? Agefrom { get; set; }
        public double? Ageto { get; set; }
        public double? Lowvalue { get; set; }
        public double? Highvalue { get; set; }
        public double? Paniclow { get; set; }
        public double? Panichigh { get; set; }
        public string Printresult { get; set; }
        public string F1 { get; set; }
        public string F2 { get; set; }
        public string F3 { get; set; }
        public string F4 { get; set; }
        public string Textrange { get; set; }
        public double? Lsageunit { get; set; }
        public string Machineid { get; set; }
    }
}
