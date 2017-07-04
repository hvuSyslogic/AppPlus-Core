using System;
using System.Runtime.Serialization;
using AppPlus.Infrastructure.Contract.Messages;

namespace HisPlus.Contract.Messages
{
    [Serializable]
    [DataContract]
    public class CkItemQcDTO : DtoBase<int>
    {
        public CkItemQcDTO()
        {
        }

        [DataMember]
        public int TestId { get; set; }

        [DataMember]
        public string QcName { get; set; }

        [DataMember]
        public decimal? Dev3 { get; set; }

        [DataMember]
        public decimal? Dev2 { get; set; }

        [DataMember]
        public decimal? Dev1 { get; set; }

        [DataMember]
        public decimal? DevM1 { get; set; }

        [DataMember]
        public decimal? DevM2 { get; set; }

        [DataMember]
        public decimal? DevM3 { get; set; }

        [DataMember]
        public decimal? AvgValue { get; set; }

        [DataMember]
        public int? CtrlId { get; set; }
    }
}
