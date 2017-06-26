using System;
using System.Runtime.Serialization;
using AppPlus.Infrastructure.Contract.Messages;

namespace HisPlus.Contract.Messages
{
    // The table 'bsitemlsit0623' is not usable by entity framework because it
    // does not have a primary key. It is listed here for completeness.
    [Serializable]
    [DataContract]
    public class Bsitemlsit0623DTO
    {
        public Bsitemlsit0623DTO()
        {
        }

        [DataMember]
        public string Illid { get; set; }

        [DataMember]
        public string Illname { get; set; }

        [DataMember]
        public double? Groupid { get; set; }

        [DataMember]
        public string Patientgroup { get; set; }

        [DataMember]
        public double? Undrugid { get; set; }

        [DataMember]
        public string Undrugname { get; set; }

        [DataMember]
        public string Typecode { get; set; }

        [DataMember]
        public double? Itemid { get; set; }

        [DataMember]
        public string Itemname { get; set; }

        [DataMember]
        public double? Unitid { get; set; }

        [DataMember]
        public string Unitname { get; set; }

        [DataMember]
        public double? Usageid { get; set; }

        [DataMember]
        public string Usagename { get; set; }

        [DataMember]
        public double? Frequencyid { get; set; }

        [DataMember]
        public string Frequencyname { get; set; }

        [DataMember]
        public double? Quantity { get; set; }

        [DataMember]
        public string Relationcode { get; set; }

        [DataMember]
        public string Waycode { get; set; }

        [DataMember]
        public string Remark { get; set; }
    }
}
