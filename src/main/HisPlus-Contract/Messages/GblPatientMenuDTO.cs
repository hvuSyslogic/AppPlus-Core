using System;
using System.Runtime.Serialization;
using HisPlus.Infrastructure.Contract.Messages;

namespace HisPlus.Contract.Messages
{
    [Serializable]
    [DataContract]
    public class GblPatientMenuDTO : DtoBase<int>
    {
        public GblPatientMenuDTO()
        {
        }

        [DataMember]
        public short LsType { get; set; }

        [DataMember]
        public string Code { get; set; }

        [DataMember]
        public string Name { get; set; }

        [DataMember]
        public int? ParentId { get; set; }

        [DataMember]
        public bool IsTitle { get; set; }

        [DataMember]
        public string FormName { get; set; }

        [DataMember]
        public string TableName { get; set; }

        [DataMember]
        public bool IsForNew { get; set; }

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
        public bool? IsAuth { get; set; }

        [DataMember]
        public bool? IsPrint { get; set; }

        [DataMember]
        public string SearchConfig { get; set; }

        [DataMember]
        public string FileEmt { get; set; }
    }
}
