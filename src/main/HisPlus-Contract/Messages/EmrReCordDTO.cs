using System;
using System.Runtime.Serialization;
using AppPlus.Infrastructure.Contract.Messages;

namespace HisPlus.Contract.Messages
{
    [Serializable]
    [DataContract]
    public class EmrReCordDTO : DtoBase<int>
    {
        public EmrReCordDTO()
        {
        }

        [DataMember]
        public System.DateTime? Intime { get; set; }

        [DataMember]
        public System.DateTime? Outtime { get; set; }

        [DataMember]
        public int? Hospid { get; set; }

        [DataMember]
        public System.DateTime? Modifytime { get; set; }

        [DataMember]
        public string Reccontent { get; set; }

        [DataMember]
        public System.DateTime? Firstretime { get; set; }

        [DataMember]
        public int? Inemrid { get; set; }

        [DataMember]
        public string F1 { get; set; }

        [DataMember]
        public string F2 { get; set; }

        [DataMember]
        public string F3 { get; set; }

        [DataMember]
        public string F4 { get; set; }

        [DataMember]
        public bool? IsActive { get; set; }

        [DataMember]
        public bool? Ismodify { get; set; }

        [DataMember]
        public int? LocationId { get; set; }
    }
}
