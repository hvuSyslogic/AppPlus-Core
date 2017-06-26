using System;
using System.Runtime.Serialization;
using AppPlus.Infrastructure.Contract.Messages;

namespace HisPlus.Contract.Messages
{
    [Serializable]
    [DataContract]
    public class GblTraceDTO : DtoBase<int>
    {
        public GblTraceDTO()
        {
        }

        [DataMember]
        public string SqlString { get; set; }

        [DataMember]
        public string WhereCondition { get; set; }

        [DataMember]
        public string OrderByExpression { get; set; }

        [DataMember]
        public bool IsActive { get; set; }

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
