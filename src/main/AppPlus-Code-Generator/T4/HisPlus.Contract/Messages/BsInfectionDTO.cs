using System;
using System.Runtime.Serialization;
using AppPlus.Infrastructure.Contract.Messages;

namespace HisPlus.Contract.Messages
{
    [Serializable]
    [DataContract]
    public class BsInfectionDTO : DtoBase<int>
    {
        public BsInfectionDTO()
        {
        }

        [DataMember]
        public string Name { get; set; }

        [DataMember]
        public int Type { get; set; }

        [DataMember]
        public string F1 { get; set; }

        [DataMember]
        public string F2 { get; set; }

        [DataMember]
        public string F3 { get; set; }

        [DataMember]
        public string F4 { get; set; }

        [DataMember]
        public bool? Isactive { get; set; }

        [DataMember]
        public int? Orderby { get; set; }
    }
}
