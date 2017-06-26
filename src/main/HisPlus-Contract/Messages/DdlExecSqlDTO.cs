using System;
using System.Runtime.Serialization;
using AppPlus.Infrastructure.Contract.Messages;

namespace HisPlus.Contract.Messages
{
    [Serializable]
    [DataContract]
    public class DdlExecSqlDTO : DtoBase<int>
    {
        public DdlExecSqlDTO()
        {
        }

        [DataMember]
        public string EventType { get; set; }

        [DataMember]
        public string SchemaName { get; set; }

        [DataMember]
        public string ObjType { get; set; }

        [DataMember]
        public string ObjName { get; set; }

        [DataMember]
        public string SqlText { get; set; }

        [DataMember]
        public System.DateTime? ExecDate { get; set; }

        [DataMember]
        public string Terminal { get; set; }
    }
}
