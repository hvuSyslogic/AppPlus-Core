using AppPlus.Infrastructure.Contract.Messages;
using System.Data.Entity.ModelConfiguration;

namespace HisPlus.Domain
{
    // The table 'bsitemfirstpagetemp' is not usable by entity framework because it
    // does not have a primary key. It is listed here for completeness.
    public class Bsitemfirstpagetemp
    {
        public Bsitemfirstpagetemp()
        {    
        }

        public double? Code { get; set; }
        public string 项目名称 { get; set; }
        public string Spec { get; set; }
        public string Psfeeid { get; set; }
        public string 病案类别名称 { get; set; }
    }
}
