using System;
using System.Runtime.Serialization;
using AppPlus.Infrastructure.Contract.Messages;

namespace HisPlus.Contract.Messages
{
    [Serializable]
    [DataContract]
    public class BsBaseCureDTO : DtoBase<int>
    {
        public BsBaseCureDTO()
        {
        }

        [DataMember]
        public string Code { get; set; }

        [DataMember]
        public string Name { get; set; }

        [DataMember]
        public string PyCode { get; set; }

        [DataMember]
        public string WbCode { get; set; }

        [DataMember]
        public short OrderBy { get; set; }

        [DataMember]
        public bool IsActive { get; set; }

        [DataMember]
        public string F1 { get; set; }

        [DataMember]
        public string F2 { get; set; }

        [DataMember]
        public string F3 { get; set; }

        [DataMember]
        public string F4 { get; set; }

        [DataMember]
        public short IconIndex { get; set; }

        [DataMember]
        public string Memo { get; set; }

        [DataMember]
        public int? GroupMainId { get; set; }

        [DataMember]
        public int? GroupSubId { get; set; }

        [DataMember]
        public int? GroupSubId2 { get; set; }

        [DataMember]
        public string EngDesc { get; set; }

        [DataMember]
        public short? LsYbType { get; set; }

        [DataMember]
        public string YbMemo { get; set; }
    }
}
