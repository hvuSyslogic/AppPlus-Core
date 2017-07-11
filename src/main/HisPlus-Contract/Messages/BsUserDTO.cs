using System;
using System.Runtime.Serialization;
using HisPlus.Infrastructure.Contract.Messages;

namespace HisPlus.Contract.Messages
{
    [Serializable]
    [DataContract]
    public class BsUserDTO : DtoBase<int>
    {
        public BsUserDTO()
        {
        }

        [DataMember]
        public string Code { get; set; }

        [DataMember]
        public string Name { get; set; }

        [DataMember]
        public string Password { get; set; }

        [DataMember]
        public bool IsActive { get; set; }

        [DataMember]
        public string Reason { get; set; }

        [DataMember]
        public short LsInputWay { get; set; }

        [DataMember]
        public short IconIndex { get; set; }

        [DataMember]
        public bool? IsUserInputWb { get; set; }

        [DataMember]
        public bool? IsUserInputPy { get; set; }

        [DataMember]
        public bool? IsUserInputCode { get; set; }

        [DataMember]
        public bool? IsUserInputName { get; set; }

        [DataMember]
        public bool? IsUserInputStrokeCode { get; set; }

        [DataMember]
        public bool? IsUserInputEngDesc { get; set; }

        [DataMember]
        public string Introduce { get; set; }

        [DataMember]
        public string PicturePath { get; set; }

        [DataMember]
        public string Address { get; set; }

        [DataMember]
        public string Mobile { get; set; }

        [DataMember]
        public int? LevelId { get; set; }

        [DataMember]
        public int? DocLevId { get; set; }

        [DataMember]
        public int? HospitalId { get; set; }

        [DataMember]
        public int? CareGroupId { get; set; }

        [DataMember]
        public int? CareGroupId1 { get; set; }

        [DataMember]
        public string CertIdNo { get; set; }

        [DataMember]
        public string PyCode { get; set; }

        [DataMember]
        public string WbCode { get; set; }

        [DataMember]
        public bool? IsUserInputF1 { get; set; }
    }
}
