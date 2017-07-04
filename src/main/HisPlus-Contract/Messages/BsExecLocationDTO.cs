using System;
using System.Runtime.Serialization;
using AppPlus.Infrastructure.Contract.Messages;

namespace HisPlus.Contract.Messages
{
    [Serializable]
    [DataContract]
    public class BsExecLocationDTO : DtoBase<int>
    {
        public BsExecLocationDTO()
        {
        }

        [DataMember]
        public int? LocationId { get; set; }

        [DataMember]
        public int ItemId { get; set; }

        [DataMember]
        public string TimeBegin { get; set; }

        [DataMember]
        public string TimeEnd { get; set; }

        [DataMember]
        public string ExecPoint { get; set; }

        [DataMember]
        public string Memo { get; set; }

        [DataMember]
        public short IconIndex { get; set; }
    }
}
