using System;
using System.Runtime.Serialization;
using AppPlus.Infrastructure.Contract.Messages;

namespace HisPlus.Contract.Messages
{
    [Serializable]
    [DataContract]
    public class BsLimitDocLevDTO : DtoBase<int>
    {
        public BsLimitDocLevDTO()
        {
        }

        [DataMember]
        public int LimitGroupId { get; set; }

        [DataMember]
        public int? DocLevId { get; set; }

        [DataMember]
        public string F1 { get; set; }

        [DataMember]
        public string F2 { get; set; }

        [DataMember]
        public string F3 { get; set; }

        [DataMember]
        public string F4 { get; set; }

        [DataMember]
        public int OrderBy { get; set; }

        [DataMember]
        public int? TypeGfxeId { get; set; }

        [DataMember]
        public decimal LimitFeeMz { get; set; }

        [DataMember]
        public decimal LimitFeeZy { get; set; }

        [DataMember]
        public string LsLimitType { get; set; }

        [DataMember]
        public bool IsActive { get; set; }
    }
}
