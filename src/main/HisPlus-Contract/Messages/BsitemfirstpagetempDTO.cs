using System;
using System.Runtime.Serialization;
using AppPlus.Infrastructure.Contract.Messages;

namespace HisPlus.Contract.Messages
{
    // The table 'bsitemfirstpagetemp' is not usable by entity framework because it
    // does not have a primary key. It is listed here for completeness.
    [Serializable]
    [DataContract]
    public class BsitemfirstpagetempDTO
    {
        public BsitemfirstpagetempDTO()
        {
        }

        [DataMember]
        public double? Code { get; set; }

        [DataMember]
        public string 项目名称 { get; set; }

        [DataMember]
        public string Spec { get; set; }

        [DataMember]
        public string Psfeeid { get; set; }

        [DataMember]
        public string 病案类别名称 { get; set; }
    }
}
