using System;
using System.Runtime.Serialization;
using HisPlus.Infrastructure.Contract.Messages;

namespace HisPlus.Contract.Messages
{
    [Serializable]
    [DataContract]
    public class InEmrDTO : DtoBase<int>
    {
        public InEmrDTO()
        {
        }

        [DataMember]
        public string RecNo { get; set; }

        [DataMember]
        public int HospId { get; set; }

        [DataMember]
        public System.DateTime OperTime { get; set; }

        [DataMember]
        public int OperId { get; set; }

        [DataMember]
        public System.DateTime? ModifyOperTime { get; set; }

        [DataMember]
        public int? ModifyOperId { get; set; }

        [DataMember]
        public int CatalogId { get; set; }

        [DataMember]
        public byte[] Content { get; set; }

        [DataMember]
        public string XmlFile { get; set; }

        [DataMember]
        public bool IsAuth { get; set; }

        [DataMember]
        public System.DateTime? AuthOperTime { get; set; }

        [DataMember]
        public int? AuthOperId { get; set; }

        [DataMember]
        public byte[] XmlContent { get; set; }

        [DataMember]
        public bool? IsRealease { get; set; }

        [DataMember]
        public System.DateTime? RealeaseTime { get; set; }

        [DataMember]
        public int? RealeaseOperId { get; set; }

        [DataMember]
        public bool? IsPrint { get; set; }

        [DataMember]
        public System.DateTime? PrintTime { get; set; }

        [DataMember]
        public int? PrintOperId { get; set; }

        [DataMember]
        public bool? IsClosed { get; set; }

        [DataMember]
        public System.DateTime? ClosedTime { get; set; }

        [DataMember]
        public int? ClosedOperId { get; set; }

        [DataMember]
        public bool? IsCheck { get; set; }

        [DataMember]
        public int? LocationId { get; set; }

        [DataMember]
        public bool? IsDelete { get; set; }

        [DataMember]
        public System.DateTime? OperTime2 { get; set; }

        [DataMember]
        public short? NodeOrderBy { get; set; }

        [DataMember]
        public string DeptName { get; set; }

        [DataMember]
        public string BedName { get; set; }

        [DataMember]
        public string EmrTypeName { get; set; }
    }
}
