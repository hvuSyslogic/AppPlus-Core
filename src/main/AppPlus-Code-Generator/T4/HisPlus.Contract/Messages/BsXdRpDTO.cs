using System;
using System.Runtime.Serialization;
using AppPlus.Infrastructure.Contract.Messages;

namespace HisPlus.Contract.Messages
{
    [Serializable]
    [DataContract]
    public class BsXdRpDTO : DtoBase<int>
    {
        public BsXdRpDTO()
        {
        }

        [DataMember]
        public string Code { get; set; }

        [DataMember]
        public string Name { get; set; }

        [DataMember]
        public string GroupMain { get; set; }

        [DataMember]
        public string GroupSub { get; set; }

        [DataMember]
        public int? OrderBy { get; set; }

        [DataMember]
        public bool IsActive { get; set; }

        [DataMember]
        public string WbCode { get; set; }

        [DataMember]
        public string PyCode { get; set; }

        [DataMember]
        public short LsOpenType { get; set; }

        [DataMember]
        public int OperId { get; set; }

        [DataMember]
        public System.DateTime OperTime { get; set; }

        [DataMember]
        public int LocationId { get; set; }

        [DataMember]
        public string F1 { get; set; }

        [DataMember]
        public string F2 { get; set; }

        [DataMember]
        public string F3 { get; set; }

        [DataMember]
        public string F4 { get; set; }

        [DataMember]
        public short IconIndex { get; set; }

        [DataMember]
        public int? TestId { get; set; }

        [DataMember]
        public short? LsInOut { get; set; }

        [DataMember]
        public int? ExecLocId { get; set; }
    }
}
