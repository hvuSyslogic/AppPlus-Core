using System;
using System.Runtime.Serialization;
using HisPlus.Infrastructure.Contract.Messages;

namespace HisPlus.Contract.Messages
{
    // The table 'OUGETALLREGINFO' is not usable by entity framework because it
    // does not have a primary key. It is listed here for completeness.
    [Serializable]
    [DataContract]
    public class OugetallreginfoDTO
    {
        public OugetallreginfoDTO()
        {
        }

        [DataMember]
        public int? Doctorid { get; set; }

        [DataMember]
        public string Doctorname { get; set; }

        [DataMember]
        public string Doctortitle { get; set; }

        [DataMember]
        public string Timereginfolist { get; set; }

        [DataMember]
        public System.DateTime? Regdate { get; set; }

        [DataMember]
        public int? Regweekday { get; set; }

        [DataMember]
        public int? Regtotalcount { get; set; }

        [DataMember]
        public int? Regleavecount { get; set; }

        [DataMember]
        public int? Totalfee { get; set; }

        [DataMember]
        public decimal? Regfee { get; set; }

        [DataMember]
        public decimal? Treatfee { get; set; }

        [DataMember]
        public int? Istimereg { get; set; }

        [DataMember]
        public int? Shifttype { get; set; }

        [DataMember]
        public int? Regstatus { get; set; }

        [DataMember]
        public string Timereginfo { get; set; }

        [DataMember]
        public string Starttime { get; set; }

        [DataMember]
        public string Timeend { get; set; }

        [DataMember]
        public int? Regtotalcount1 { get; set; }

        [DataMember]
        public int? Regleavecount1 { get; set; }

        [DataMember]
        public int? Locationid { get; set; }

        [DataMember]
        public short? Iscancel { get; set; }

        [DataMember]
        public string Onlyid { get; set; }

        [DataMember]
        public string Roomname { get; set; }
    }
}
