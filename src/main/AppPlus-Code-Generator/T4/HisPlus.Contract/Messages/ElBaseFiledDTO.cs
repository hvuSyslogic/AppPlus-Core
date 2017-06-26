using System;
using System.Runtime.Serialization;
using AppPlus.Infrastructure.Contract.Messages;

namespace HisPlus.Contract.Messages
{
    [Serializable]
    [DataContract]
    public class ElBaseFiledDTO : DtoBase<int>
    {
        public ElBaseFiledDTO()
        {
        }

        [DataMember]
        public string Code { get; set; }

        [DataMember]
        public string Name { get; set; }

        [DataMember]
        public short? LsDataType { get; set; }

        [DataMember]
        public short? Lengh { get; set; }

        [DataMember]
        public string EditMask { get; set; }

        [DataMember]
        public string Memo { get; set; }

        [DataMember]
        public string ToolTips { get; set; }

        [DataMember]
        public string ErrorTips { get; set; }

        [DataMember]
        public bool? IsHasChild { get; set; }

        [DataMember]
        public short? OrderBy { get; set; }

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
        public bool? IsEncrypt { get; set; }

        [DataMember]
        public bool? IsLog { get; set; }
    }
}
