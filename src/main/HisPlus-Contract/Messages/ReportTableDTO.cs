using System;
using System.Runtime.Serialization;
using AppPlus.Infrastructure.Contract.Messages;

namespace HisPlus.Contract.Messages
{
    [Serializable]
    [DataContract]
    public class ReportTableDTO : DtoBase<decimal>
    {
        public ReportTableDTO()
        {
        }

        [DataMember]
        public string TabelName { get; set; }

        [DataMember]
        public string FiledName { get; set; }

        [DataMember]
        public string FiledZw { get; set; }

        [DataMember]
        public string FiledType { get; set; }
    }
}
