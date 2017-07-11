using System;
using System.Runtime.Serialization;
using HisPlus.Infrastructure.Contract.Messages;

namespace HisPlus.Contract.Messages
{
    [Serializable]
    [DataContract]
    public class BsPatTypeDTO : DtoBase<int>
    {
        public BsPatTypeDTO()
        {
        }

        [DataMember]
        public string Code { get; set; }

        [DataMember]
        public string Name { get; set; }

        [DataMember]
        public decimal LimitFee { get; set; }

        [DataMember]
        public decimal LimitIn { get; set; }

        [DataMember]
        public decimal ArrearFei { get; set; }

        [DataMember]
        public decimal DiscDiag { get; set; }

        [DataMember]
        public decimal DiscIn { get; set; }

        [DataMember]
        public string HeadNo { get; set; }

        [DataMember]
        public int TallyTypeId { get; set; }

        [DataMember]
        public decimal ArrearAmount { get; set; }

        [DataMember]
        public short? LsGfPatType { get; set; }

        [DataMember]
        public string WbCode { get; set; }

        [DataMember]
        public string PyCode { get; set; }

        [DataMember]
        public bool IsActive { get; set; }

        [DataMember]
        public short OrderBy { get; set; }

        [DataMember]
        public short IconIndex { get; set; }

        [DataMember]
        public decimal? TwoDiscIn1 { get; set; }

        [DataMember]
        public decimal? TwoDiscIn2 { get; set; }
    }
}
