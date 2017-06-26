using System;
using System.Runtime.Serialization;
using AppPlus.Infrastructure.Contract.Messages;

namespace HisPlus.Contract.Messages
{
    [Serializable]
    [DataContract]
    public class NfInfectTestBacteriaDTO : DtoBase<int>
    {
        public NfInfectTestBacteriaDTO()
        {
        }

        [DataMember]
        public int TestId { get; set; }

        [DataMember]
        public int BacteriaId { get; set; }

        [DataMember]
        public int? BaseDrugId { get; set; }

        [DataMember]
        public short? LsResult { get; set; }

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
