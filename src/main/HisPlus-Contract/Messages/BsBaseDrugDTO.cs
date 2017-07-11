using System;
using System.Runtime.Serialization;
using HisPlus.Infrastructure.Contract.Messages;

namespace HisPlus.Contract.Messages
{
    [Serializable]
    [DataContract]
    public class BsBaseDrugDTO : DtoBase<int>
    {
        public BsBaseDrugDTO()
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
        public short IconIndex { get; set; }

        [DataMember]
        public decimal PriceIn { get; set; }

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

        [DataMember]
        public int? GroupSubId3 { get; set; }

        [DataMember]
        public int? GroupSubId4 { get; set; }
    }
}
