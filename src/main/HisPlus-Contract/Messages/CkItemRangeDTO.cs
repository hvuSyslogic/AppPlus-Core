using System;
using System.Runtime.Serialization;
using AppPlus.Infrastructure.Contract.Messages;

namespace HisPlus.Contract.Messages
{
    [Serializable]
    [DataContract]
    public class CkItemRangeDTO : DtoBase<int>
    {
        public CkItemRangeDTO()
        {
        }

        [DataMember]
        public int TestId { get; set; }

        [DataMember]
        public string Sex { get; set; }

        [DataMember]
        public int AgeFrom { get; set; }

        [DataMember]
        public int AgeTo { get; set; }

        [DataMember]
        public decimal LowValue { get; set; }

        [DataMember]
        public decimal HighValue { get; set; }

        [DataMember]
        public decimal PanicLow { get; set; }

        [DataMember]
        public decimal PanicHigh { get; set; }

        [DataMember]
        public string PrintResult { get; set; }

        [DataMember]
        public string F1 { get; set; }

        [DataMember]
        public string F2 { get; set; }

        [DataMember]
        public string F3 { get; set; }

        [DataMember]
        public string F4 { get; set; }

        [DataMember]
        public string TextRange { get; set; }

        [DataMember]
        public short? LsAgeUnit { get; set; }

        [DataMember]
        public int? MachineId { get; set; }
    }
}
