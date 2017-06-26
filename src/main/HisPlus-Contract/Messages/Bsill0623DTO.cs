using System;
using System.Runtime.Serialization;
using AppPlus.Infrastructure.Contract.Messages;

namespace HisPlus.Contract.Messages
{
    // The table 'bsill0623' is not usable by entity framework because it
    // does not have a primary key. It is listed here for completeness.
    [Serializable]
    [DataContract]
    public class Bsill0623DTO
    {
        public Bsill0623DTO()
        {
        }

        [DataMember]
        public string Name { get; set; }

        [DataMember]
        public string Patientgroup { get; set; }

        [DataMember]
        public string Treatment { get; set; }

        [DataMember]
        public string Detail { get; set; }

        [DataMember]
        public double? Orderby { get; set; }

        [DataMember]
        public double? Treatorderby { get; set; }
    }
}
