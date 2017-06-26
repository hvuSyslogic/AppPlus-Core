using System;
using System.Runtime.Serialization;
using AppPlus.Infrastructure.Contract.Messages;

namespace HisPlus.Contract.Messages
{
    [Serializable]
    [DataContract]
    public class BsDoctorBackDTO : DtoBase<int>
    {
        public BsDoctorBackDTO()
        {
        }

        [DataMember]
        public System.DateTime? BirthDate { get; set; }

        [DataMember]
        public int? LevelId { get; set; }

        [DataMember]
        public int? DocLevId { get; set; }

        [DataMember]
        public int? RegTypeId { get; set; }

        [DataMember]
        public string F1 { get; set; }

        [DataMember]
        public string F2 { get; set; }

        [DataMember]
        public string F3 { get; set; }

        [DataMember]
        public string F4 { get; set; }

        [DataMember]
        public int? UserId { get; set; }

        [DataMember]
        public string PyCode { get; set; }

        [DataMember]
        public string WbCode { get; set; }

        [DataMember]
        public int? SupDoctorId { get; set; }
    }
}
