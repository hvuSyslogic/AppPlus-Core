using System;
using System.Runtime.Serialization;
using AppPlus.Infrastructure.Contract.Messages;

namespace HisPlus.Contract.Messages
{
    [Serializable]
    [DataContract]
    public class GblReportDTO : DtoBase<int>
    {
        public GblReportDTO()
        {
        }

        [DataMember]
        public string Name { get; set; }

        [DataMember]
        public short OrderBy { get; set; }

        [DataMember]
        public bool IsActive { get; set; }

        [DataMember]
        public short LsOutOrIn { get; set; }

        [DataMember]
        public short IconIndex { get; set; }
    }
}
