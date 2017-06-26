using System;
using System.Runtime.Serialization;
using AppPlus.Infrastructure.Contract.Messages;

namespace HisPlus.Contract.Messages
{
    [Serializable]
    [DataContract]
    public class CkBloodSendDTO : DtoBase<int>
    {
        public CkBloodSendDTO()
        {
        }

        [DataMember]
        public string RecNo { get; set; }

        [DataMember]
        public int LabId { get; set; }

        [DataMember]
        public int BloodId { get; set; }

        [DataMember]
        public System.DateTime NoteTime { get; set; }

        [DataMember]
        public int NoteOperId { get; set; }

        [DataMember]
        public bool? IsSend { get; set; }

        [DataMember]
        public System.DateTime? SendTime { get; set; }

        [DataMember]
        public int? SendOperId { get; set; }

        [DataMember]
        public string TakeMan { get; set; }

        [DataMember]
        public string Memo { get; set; }

        [DataMember]
        public System.DateTime? OperTime { get; set; }

        [DataMember]
        public int? OperId { get; set; }

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
