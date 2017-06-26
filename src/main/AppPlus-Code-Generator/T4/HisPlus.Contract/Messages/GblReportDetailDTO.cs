using System;
using System.Runtime.Serialization;
using AppPlus.Infrastructure.Contract.Messages;

namespace HisPlus.Contract.Messages
{
    [Serializable]
    [DataContract]
    public class GblReportDetailDTO : DtoBase<int>
    {
        public GblReportDetailDTO()
        {
        }

        [DataMember]
        public int GroupId { get; set; }

        [DataMember]
        public int FeeId { get; set; }
    }
}
