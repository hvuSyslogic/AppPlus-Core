using System;
using System.Runtime.Serialization;
using HisPlus.Infrastructure.Contract.Messages;

namespace HisPlus.Contract.Messages
{
    [Serializable]
    [DataContract]
    public class BsLimitGroupDTO : DtoBase<int>
    {
        public BsLimitGroupDTO()
        {
        }

        [DataMember]
        public string Code { get; set; }

        [DataMember]
        public string Name { get; set; }

        [DataMember]
        public int? PatTypeId { get; set; }

        [DataMember]
        public int? TypeGfxeId { get; set; }

        [DataMember]
        public decimal LimitFeeMz { get; set; }

        [DataMember]
        public decimal LimitFeeZy { get; set; }

        [DataMember]
        public string LsLimitType { get; set; }

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
        public int? DocLevelId { get; set; }
    }
}
