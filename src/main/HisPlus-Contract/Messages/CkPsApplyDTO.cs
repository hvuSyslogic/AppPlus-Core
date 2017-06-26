using System;
using System.Runtime.Serialization;
using AppPlus.Infrastructure.Contract.Messages;

namespace HisPlus.Contract.Messages
{
    [Serializable]
    [DataContract]
    public class CkPsApplyDTO : DtoBase<int>
    {
        public CkPsApplyDTO()
        {
        }

        [DataMember]
        public string ApplyId { get; set; }

        [DataMember]
        public int CheckId { get; set; }

        [DataMember]
        public int ItemId { get; set; }

        [DataMember]
        public string CheckBody { get; set; }

        [DataMember]
        public short XType { get; set; }

        [DataMember]
        public string F1 { get; set; }

        [DataMember]
        public string F2 { get; set; }

        [DataMember]
        public string F3 { get; set; }

        [DataMember]
        public string F4 { get; set; }
    }
}
