using System;
using System.Runtime.Serialization;
using HisPlus.Infrastructure.Contract.Messages;

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
    }
}
