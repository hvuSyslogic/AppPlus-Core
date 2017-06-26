using System;
using System.Runtime.Serialization;
using AppPlus.Infrastructure.Contract.Messages;

namespace HisPlus.Contract.Messages
{
    [Serializable]
    [DataContract]
    public class RmGroupPrintNumDTO : DtoBase<int>
    {
        public RmGroupPrintNumDTO()
        {
        }

        [DataMember]
        public System.DateTime? PrintDate { get; set; }

        [DataMember]
        public int? Group1PageNum { get; set; }

        [DataMember]
        public int? Group2PageNum { get; set; }

        [DataMember]
        public int? Group3PageNum { get; set; }

        [DataMember]
        public int? Group4PageNum { get; set; }

        [DataMember]
        public int? Group5PageNum { get; set; }

        [DataMember]
        public int? Group6PageNum { get; set; }

        [DataMember]
        public int? PreviousGroup1PageNum { get; set; }

        [DataMember]
        public int? PreviousGroup2PageNum { get; set; }

        [DataMember]
        public int? PreviousGroup3PageNum { get; set; }

        [DataMember]
        public int? PreviousGroup4PageNum { get; set; }

        [DataMember]
        public int? PreviousGroup5PageNum { get; set; }

        [DataMember]
        public int? PreviousGroup6PageNum { get; set; }

        [DataMember]
        public string F1 { get; set; }

        [DataMember]
        public string F2 { get; set; }

        [DataMember]
        public string F3 { get; set; }

        [DataMember]
        public string F4 { get; set; }
    }
}
