using AppPlus.Infrastructure.Contract.Messages;
using System.Data.Entity.ModelConfiguration;

namespace HisPlus.Domain
{
    // The table 'bsitemlsit0623' is not usable by entity framework because it
    // does not have a primary key. It is listed here for completeness.
    public class Bsitemlsit0623
    {
        public Bsitemlsit0623()
        {    
        }

        public string Illid { get; set; }
        public string Illname { get; set; }
        public double? Groupid { get; set; }
        public string Patientgroup { get; set; }
        public double? Undrugid { get; set; }
        public string Undrugname { get; set; }
        public string Typecode { get; set; }
        public double? Itemid { get; set; }
        public string Itemname { get; set; }
        public double? Unitid { get; set; }
        public string Unitname { get; set; }
        public double? Usageid { get; set; }
        public string Usagename { get; set; }
        public double? Frequencyid { get; set; }
        public string Frequencyname { get; set; }
        public double? Quantity { get; set; }
        public string Relationcode { get; set; }
        public string Waycode { get; set; }
        public string Remark { get; set; }
    }
}
