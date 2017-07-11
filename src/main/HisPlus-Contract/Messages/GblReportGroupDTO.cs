using System;
using System.Runtime.Serialization;
using HisPlus.Infrastructure.Contract.Messages;

namespace HisPlus.Contract.Messages
{
    [Serializable]
    [DataContract]
    public class GblReportGroupDTO : DtoBase<int>
    {
        public GblReportGroupDTO()
        {
        }

        [DataMember]
        public int ReportId { get; set; }

        [DataMember]
        public string Name { get; set; }

        [DataMember]
        public int OrderBy { get; set; }
    }
}
