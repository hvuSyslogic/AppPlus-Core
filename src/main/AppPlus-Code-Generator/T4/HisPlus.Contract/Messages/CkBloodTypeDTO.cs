using System;
using System.Runtime.Serialization;
using AppPlus.Infrastructure.Contract.Messages;

namespace HisPlus.Contract.Messages
{
    [Serializable]
    [DataContract]
    public class CkBloodTypeDTO : DtoBase<int>
    {
        public CkBloodTypeDTO()
        {
        }

        [DataMember]
        public string Code { get; set; }

        [DataMember]
        public string Name { get; set; }

        [DataMember]
        public decimal PriceIn { get; set; }

        [DataMember]
        public decimal PriceOut { get; set; }

        [DataMember]
        public short LimitDays { get; set; }

        [DataMember]
        public int UnitId { get; set; }

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
        public decimal? UnderLineKc { get; set; }
    }
}
