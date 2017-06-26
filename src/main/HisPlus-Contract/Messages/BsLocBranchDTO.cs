using System;
using System.Runtime.Serialization;
using AppPlus.Infrastructure.Contract.Messages;

namespace HisPlus.Contract.Messages
{
    [Serializable]
    [DataContract]
    public class BsLocBranchDTO : DtoBase<int>
    {
        public BsLocBranchDTO()
        {
        }

        [DataMember]
        public int LocationId { get; set; }

        [DataMember]
        public int BranchId { get; set; }

        [DataMember]
        public string Director { get; set; }

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
