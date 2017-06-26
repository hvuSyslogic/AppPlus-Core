using System;
using System.Runtime.Serialization;
using AppPlus.Infrastructure.Contract.Messages;

namespace HisPlus.Contract.Messages
{
    [Serializable]
    [DataContract]
    public class DgIllSymptomDTO : DtoBase<int>
    {
        public DgIllSymptomDTO()
        {
        }

        [DataMember]
        public int? IcdId { get; set; }

        [DataMember]
        public string Symptom { get; set; }

        [DataMember]
        public bool? IsBaby { get; set; }

        [DataMember]
        public bool? IsWomen { get; set; }

        [DataMember]
        public bool? IsMen { get; set; }

        [DataMember]
        public bool? IsOlder { get; set; }

        [DataMember]
        public string Memo { get; set; }

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
    }
}
