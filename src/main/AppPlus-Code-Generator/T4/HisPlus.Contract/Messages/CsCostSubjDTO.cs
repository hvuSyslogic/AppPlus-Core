using System;
using System.Runtime.Serialization;
using AppPlus.Infrastructure.Contract.Messages;

namespace HisPlus.Contract.Messages
{
    [Serializable]
    [DataContract]
    public class CsCostSubjDTO : DtoBase<int>
    {
        public CsCostSubjDTO()
        {
        }

        [DataMember]
        public string Code { get; set; }

        [DataMember]
        public string Name { get; set; }

        [DataMember]
        public string SuppItemCode { get; set; }

        [DataMember]
        public short? LsTreatMed { get; set; }

        [DataMember]
        public bool? IsLastLevel { get; set; }

        [DataMember]
        public int? CostSubjGrade { get; set; }

        [DataMember]
        public string PyCode { get; set; }

        [DataMember]
        public bool? IsActive { get; set; }

        [DataMember]
        public string F1 { get; set; }

        [DataMember]
        public string F2 { get; set; }

        [DataMember]
        public string F3 { get; set; }

        [DataMember]
        public string F4 { get; set; }

        [DataMember]
        public bool? IsFix { get; set; }

        [DataMember]
        public short? LsType { get; set; }

        [DataMember]
        public int? ClassId { get; set; }

        [DataMember]
        public string WbCode { get; set; }

        [DataMember]
        public short? OrderBy { get; set; }

        [DataMember]
        public bool? IsDerect { get; set; }

        [DataMember]
        public short? LsAppPara { get; set; }

        [DataMember]
        public string ToLocIds { get; set; }
    }
}
