using System;
using System.Runtime.Serialization;
using HisPlus.Infrastructure.Contract.Messages;

namespace HisPlus.Contract.Messages
{
    [Serializable]
    [DataContract]
    public class CkMachineDTO : DtoBase<int>
    {
        public CkMachineDTO()
        {
        }

        [DataMember]
        public string Code { get; set; }

        [DataMember]
        public string Name { get; set; }

        [DataMember]
        public int TestTypeId { get; set; }

        [DataMember]
        public int? TypeNum { get; set; }

        [DataMember]
        public string MachineNum { get; set; }

        [DataMember]
        public string FirstSampleNum { get; set; }

        [DataMember]
        public string LastSampleNum { get; set; }

        [DataMember]
        public System.DateTime? SampleBeginDate { get; set; }

        [DataMember]
        public string PyCode { get; set; }

        [DataMember]
        public string WbCode { get; set; }

        [DataMember]
        public short OrderBy { get; set; }

        [DataMember]
        public bool IsActive { get; set; }

        [DataMember]
        public short? IconIndex { get; set; }
    }
}
