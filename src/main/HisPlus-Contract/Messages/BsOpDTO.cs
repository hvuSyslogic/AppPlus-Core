using System;
using System.Runtime.Serialization;
using HisPlus.Infrastructure.Contract.Messages;

namespace HisPlus.Contract.Messages
{
    [Serializable]
    [DataContract]
    public class BsOpDTO : DtoBase<int>
    {
        public BsOpDTO()
        {
        }

        [DataMember]
        public string Code { get; set; }

        [DataMember]
        public string Name { get; set; }

        [DataMember]
        public string PyCode { get; set; }

        [DataMember]
        public string WbCode { get; set; }

        [DataMember]
        public short OrderBy { get; set; }

        [DataMember]
        public bool IsActive { get; set; }

        [DataMember]
        public short IconIndex { get; set; }

        [DataMember]
        public short? LsClass { get; set; }

        [DataMember]
        public short? LsAsa { get; set; }

        [DataMember]
        public bool? IsEmergency { get; set; }

        [DataMember]
        public int? AnaesId { get; set; }

        [DataMember]
        public int? Minutes { get; set; }

        [DataMember]
        public bool? IsImplant { get; set; }

        [DataMember]
        public bool? IsImglass { get; set; }

        [DataMember]
        public bool? IsOpsDrug { get; set; }

        [DataMember]
        public decimal? DangerPoint { get; set; }
    }
}
