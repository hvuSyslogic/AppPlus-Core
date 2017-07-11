using System;
using System.Runtime.Serialization;
using HisPlus.Infrastructure.Contract.Messages;

namespace HisPlus.Contract.Messages
{
    [Serializable]
    [DataContract]
    public class BsRegSpanSubDTO : DtoBase<int>
    {
        public BsRegSpanSubDTO()
        {
        }

        [DataMember]
        public string Code { get; set; }

        [DataMember]
        public string Name { get; set; }

        [DataMember]
        public string TimeBegin { get; set; }

        [DataMember]
        public string TimeEnd { get; set; }

        [DataMember]
        public bool IsActive { get; set; }

        [DataMember]
        public short IconIndex { get; set; }

        [DataMember]
        public int? TimeSpanId { get; set; }

        [DataMember]
        public short? NoSource { get; set; }
    }
}
