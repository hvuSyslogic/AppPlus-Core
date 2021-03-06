using System;
using System.Runtime.Serialization;
using HisPlus.Infrastructure.Contract.Messages;

namespace HisPlus.Contract.Messages
{
    [Serializable]
    [DataContract]
    public class BsHealthEduRecDTO : DtoBase<int>
    {
        public BsHealthEduRecDTO()
        {
        }

        [DataMember]
        public string Code { get; set; }

        [DataMember]
        public int HealthEduRec { get; set; }

        [DataMember]
        public string Name { get; set; }

        [DataMember]
        public string Rmark { get; set; }

        [DataMember]
        public string PyCode { get; set; }

        [DataMember]
        public string WbCode { get; set; }

        [DataMember]
        public short OrderBy { get; set; }

        [DataMember]
        public bool IsActive { get; set; }

        [DataMember]
        public bool? IdleFlag { get; set; }

        [DataMember]
        public short IconIndex { get; set; }
    }
}
