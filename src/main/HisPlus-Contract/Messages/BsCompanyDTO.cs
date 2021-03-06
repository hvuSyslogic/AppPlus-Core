using System;
using System.Runtime.Serialization;
using HisPlus.Infrastructure.Contract.Messages;

namespace HisPlus.Contract.Messages
{
    [Serializable]
    [DataContract]
    public class BsCompanyDTO : DtoBase<int>
    {
        public BsCompanyDTO()
        {
        }

        [DataMember]
        public string Code { get; set; }

        [DataMember]
        public string Name { get; set; }

        [DataMember]
        public string CompAddre { get; set; }

        [DataMember]
        public string CompCorpo { get; set; }

        [DataMember]
        public string CompPhone { get; set; }

        [DataMember]
        public string Bank { get; set; }

        [DataMember]
        public string BankAccount { get; set; }

        [DataMember]
        public short OrderBy { get; set; }

        [DataMember]
        public bool IsActive { get; set; }

        [DataMember]
        public string PyCode { get; set; }

        [DataMember]
        public string WbCode { get; set; }

        [DataMember]
        public short IconIndex { get; set; }

        [DataMember]
        public short? LsType { get; set; }
    }
}
