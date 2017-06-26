using System;
using System.Runtime.Serialization;
using AppPlus.Infrastructure.Contract.Messages;

namespace HisPlus.Contract.Messages
{
    [Serializable]
    [DataContract]
    public class CsCostClassDTO : DtoBase<int>
    {
        public CsCostClassDTO()
        {
        }

        [DataMember]
        public string Code { get; set; }

        [DataMember]
        public string Name { get; set; }

        [DataMember]
        public string SuppItemCode { get; set; }

        [DataMember]
        public bool? IsActive { get; set; }

        [DataMember]
        public string LastLevel { get; set; }

        [DataMember]
        public string PyCode { get; set; }

        [DataMember]
        public string F1 { get; set; }

        [DataMember]
        public string F2 { get; set; }

        [DataMember]
        public string F3 { get; set; }

        [DataMember]
        public string F4 { get; set; }

        [DataMember]
        public string WbCode { get; set; }

        [DataMember]
        public short? OrderBy { get; set; }
    }
}
