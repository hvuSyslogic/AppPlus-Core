using System;
using System.Runtime.Serialization;
using AppPlus.Infrastructure.Contract.Messages;

namespace HisPlus.Contract.Messages
{
    [Serializable]
    [DataContract]
    public class NrPregnancyDtlDTO : DtoBase<int>
    {
        public NrPregnancyDtlDTO()
        {
        }

        [DataMember]
        public int? PregnancyId { get; set; }

        [DataMember]
        public int? OperId { get; set; }

        [DataMember]
        public System.DateTime? OperTime { get; set; }

        [DataMember]
        public decimal? ExamBp { get; set; }

        [DataMember]
        public decimal? ExamBp2 { get; set; }

        [DataMember]
        public string Strength { get; set; }

        [DataMember]
        public string LongTimes { get; set; }

        [DataMember]
        public string Sometimes { get; set; }

        [DataMember]
        public string UterusHigh { get; set; }

        [DataMember]
        public string Post { get; set; }

        [DataMember]
        public string Speed { get; set; }

        [DataMember]
        public string Place { get; set; }

        [DataMember]
        public string FirstHigh { get; set; }

        [DataMember]
        public string Lengh { get; set; }

        [DataMember]
        public string Expand { get; set; }

        [DataMember]
        public string Membrane { get; set; }

        [DataMember]
        public string Anus { get; set; }

        [DataMember]
        public string Vagina { get; set; }

        [DataMember]
        public string Others { get; set; }

        [DataMember]
        public string CheckMan { get; set; }

        [DataMember]
        public string CenterTimes { get; set; }

        [DataMember]
        public string LinkUp { get; set; }

        [DataMember]
        public string Score { get; set; }

        [DataMember]
        public string AmniFluid { get; set; }

        [DataMember]
        public string VaginaBleed { get; set; }

        [DataMember]
        public string MoveTimes { get; set; }

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
