using System;
using System.Runtime.Serialization;
using AppPlus.Infrastructure.Contract.Messages;

namespace HisPlus.Contract.Messages
{
    [Serializable]
    [DataContract]
    public class EqAttachDTO : DtoBase<int>
    {
        public EqAttachDTO()
        {
        }

        [DataMember]
        public int EquipmentId { get; set; }

        [DataMember]
        public string FileName { get; set; }

        [DataMember]
        public string LsFileType { get; set; }

        [DataMember]
        public byte[] AttachFile { get; set; }

        [DataMember]
        public string F1 { get; set; }

        [DataMember]
        public string F2 { get; set; }

        [DataMember]
        public string F3 { get; set; }

        [DataMember]
        public string F4 { get; set; }
    }
}
