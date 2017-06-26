using System;
using System.Runtime.Serialization;
using AppPlus.Infrastructure.Contract.Messages;

namespace HisPlus.Contract.Messages
{
    [Serializable]
    [DataContract]
    public class BsDoctorDTO : DtoBase<int>
    {
        public BsDoctorDTO()
        {
        }

        [DataMember]
        public string Code { get; set; }

        [DataMember]
        public string Name { get; set; }

        [DataMember]
        public string Sex { get; set; }

        [DataMember]
        public System.DateTime? BirthDate { get; set; }

        [DataMember]
        public string Address { get; set; }

        [DataMember]
        public string City { get; set; }

        [DataMember]
        public string Mobile { get; set; }

        [DataMember]
        public string Email { get; set; }

        [DataMember]
        public int? LevelId { get; set; }

        [DataMember]
        public int? DocLevId { get; set; }

        [DataMember]
        public string Introduce { get; set; }

        [DataMember]
        public int? LocationId { get; set; }

        [DataMember]
        public int? RegTypeId { get; set; }

        [DataMember]
        public string PicturePath { get; set; }

        [DataMember]
        public short LsStatus { get; set; }

        [DataMember]
        public short OrderBy { get; set; }

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
        public int? UserId { get; set; }

        [DataMember]
        public string PyCode { get; set; }

        [DataMember]
        public string WbCode { get; set; }

        [DataMember]
        public int? SupDoctorId { get; set; }

        [DataMember]
        public int? DiagRoomId { get; set; }

        [DataMember]
        public System.DateTime? OperTime { get; set; }
    }
}
