using AppPlus.Infrastructure.Contract.Messages;

namespace HisPlus.Contract.Messages
{
    public class OugetreginfoDTO : DtoBase<int>
    {
        public OugetreginfoDTO()
        {
        }

        public string Timereginfolist { get; set; }
        public System.DateTime? Regdate { get; set; }
        public int? Regweekday { get; set; }
        public int? Regtotalcount { get; set; }
        public int? Regleavecount { get; set; }
        public int? Totalfee { get; set; }
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
