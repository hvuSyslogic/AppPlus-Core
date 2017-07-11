using System;
using System.Runtime.Serialization;
using HisPlus.Infrastructure.Contract.Messages;

namespace HisPlus.Contract.Messages
{
    [Serializable]
    [DataContract]
    public class BsRegPatAmountDTO : DtoBase<int>
    {
        public BsRegPatAmountDTO()
        {
        }

        [DataMember]
        public int RegTypeId { get; set; }

        [DataMember]
        public int PatTypeId { get; set; }

        [DataMember]
        public decimal RegFee { get; set; }

        [DataMember]
        public decimal DiagnoFee { get; set; }

        [DataMember]
        public decimal OtherFee1 { get; set; }

        [DataMember]
        public decimal OtherFee2 { get; set; }

        [DataMember]
        public decimal PaySel { get; set; }

        [DataMember]
        public decimal TallyFee { get; set; }

        [DataMember]
        public short IconIndex { get; set; }
    }
}
