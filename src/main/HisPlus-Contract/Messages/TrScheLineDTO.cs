using System;
using System.Runtime.Serialization;
using HisPlus.Infrastructure.Contract.Messages;

namespace HisPlus.Contract.Messages
{
    [Serializable]
    [DataContract]
    public class TrScheLineDTO : DtoBase<int>
    {
        public TrScheLineDTO()
        {
        }

        [DataMember]
        public string Code { get; set; }

        [DataMember]
        public string Name { get; set; }

        [DataMember]
        public int? LocationId { get; set; }

        [DataMember]
        public string Memo { get; set; }

        [DataMember]
        public string PyCode { get; set; }

        [DataMember]
        public string WbCode { get; set; }

        [DataMember]
        public short OrderBy { get; set; }

        [DataMember]
        public bool IsActive { get; set; }

        [DataMember]
        public int? LabelId { get; set; }

        [DataMember]
        public System.DateTime? StartTime { get; set; }

        [DataMember]
        public System.DateTime? EndTime { get; set; }
    }
}
