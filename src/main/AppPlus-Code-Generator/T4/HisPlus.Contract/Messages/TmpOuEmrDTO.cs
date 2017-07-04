using System;
using System.Runtime.Serialization;
using AppPlus.Infrastructure.Contract.Messages;

namespace HisPlus.Contract.Messages
{
    [Serializable]
    [DataContract]
    public class TmpOuEmrDTO : DtoBase<int>
    {
        public TmpOuEmrDTO()
        {
        }

        [DataMember]
        public string Name { get; set; }

        [DataMember]
        public string GroupMain { get; set; }

        [DataMember]
        public string GroupSub { get; set; }

        [DataMember]
        public short? OrderBy { get; set; }

        [DataMember]
        public bool? IsActive { get; set; }

        [DataMember]
        public string WbCode { get; set; }

        [DataMember]
        public string PyCode { get; set; }

        [DataMember]
        public short? LsOpenType { get; set; }

        [DataMember]
        public int? OperId { get; set; }

        [DataMember]
        public System.DateTime? OperTime { get; set; }

        [DataMember]
        public int? LocationId { get; set; }

        [DataMember]
        public string MainInform { get; set; }

        [DataMember]
        public string SickHist { get; set; }

        [DataMember]
        public decimal? ExamT { get; set; }

        [DataMember]
        public decimal? ExamP { get; set; }

        [DataMember]
        public decimal? ExamR { get; set; }

        [DataMember]
        public decimal? ExamBp { get; set; }

        [DataMember]
        public decimal? ExamBp2 { get; set; }

        [DataMember]
        public string CheckUp { get; set; }

        [DataMember]
        public string CheckCt { get; set; }

        [DataMember]
        public string Disposal { get; set; }

        [DataMember]
        public string Impression { get; set; }

        [DataMember]
        public string Analys { get; set; }

        [DataMember]
        public string Others { get; set; }

        [DataMember]
        public string Tongue { get; set; }

        [DataMember]
        public string Pulse { get; set; }

        [DataMember]
        public string Moss { get; set; }
    }
}
