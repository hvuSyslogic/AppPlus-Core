using AppPlus.Infrastructure.Contract.Messages;
using System.Data.Entity.ModelConfiguration;

namespace HisPlus.Domain
{
    // The table 'OUGETALLREGINFO' is not usable by entity framework because it
    // does not have a primary key. It is listed here for completeness.
    public class Ougetallreginfo
    {
        public Ougetallreginfo()
        {    
        }

        public int? Doctorid { get; set; }
        public string Doctorname { get; set; }
        public string Doctortitle { get; set; }
        public string Timereginfolist { get; set; }
        public System.DateTime? Regdate { get; set; }
        public int? Regweekday { get; set; }
        public int? Regtotalcount { get; set; }
        public int? Regleavecount { get; set; }
        public int? Totalfee { get; set; }
        public decimal? Regfee { get; set; }
        public decimal? Treatfee { get; set; }
        public int? Istimereg { get; set; }
        public int? Shifttype { get; set; }
        public int? Regstatus { get; set; }
        public string Timereginfo { get; set; }
        public string Starttime { get; set; }
        public string Timeend { get; set; }
        public int? Regtotalcount1 { get; set; }
        public int? Regleavecount1 { get; set; }
        public int? Locationid { get; set; }
        public short? Iscancel { get; set; }
        public string Onlyid { get; set; }
        public string Roomname { get; set; }
    }
}
