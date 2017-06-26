using System;
using System.Runtime.Serialization;
using AppPlus.Infrastructure.Contract.Messages;

namespace HisPlus.Contract.Messages
{
    [Serializable]
    [DataContract]
    public class OugetreginfoDTO : DtoBase<int>
    {
        public OugetreginfoDTO()
        {
        }

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
