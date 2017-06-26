using System;
using System.Runtime.Serialization;
using AppPlus.Infrastructure.Contract.Messages;

namespace HisPlus.Contract.Messages
{
    [Serializable]
    [DataContract]
    public class NfInfectDrugDTO : DtoBase<int>
    {
        public NfInfectDrugDTO()
        {
        }

        [DataMember]
        public int InfectId { get; set; }

        [DataMember]
        public int BaseDrugId { get; set; }

        [DataMember]
        public decimal Dosage { get; set; }

        [DataMember]
        public int? UnitTakeId { get; set; }

        [DataMember]
        public int? FrequencyId { get; set; }

        [DataMember]
        public int? UsageId { get; set; }

        [DataMember]
        public short? Days { get; set; }
    }
}
