using System;
using System.Runtime.Serialization;
using AppPlus.Infrastructure.Contract.Messages;

namespace HisPlus.Contract.Messages
{
    [Serializable]
    [DataContract]
    public class BsCareGroupDTO : DtoBase<int>
    {
        public BsCareGroupDTO()
        {
        }

        [DataMember]
        public string Code { get; set; }

        [DataMember]
        public string Name { get; set; }

        [DataMember]
        public string WbCode { get; set; }

        [DataMember]
        public string PyCode { get; set; }

        [DataMember]
        public short OrderBy { get; set; }

        [DataMember]
        public bool IsActive { get; set; }

        [DataMember]
        public int? DoctorId { get; set; }

        [DataMember]
        public int? NurseUserId { get; set; }

        [DataMember]
        public int? GuardUserId { get; set; }

        [DataMember]
        public int? OtherUserId { get; set; }

        [DataMember]
        public short IconIndex { get; set; }
    }
}
