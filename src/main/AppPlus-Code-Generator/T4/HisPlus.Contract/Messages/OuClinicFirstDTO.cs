using System;
using System.Runtime.Serialization;
using AppPlus.Infrastructure.Contract.Messages;

namespace HisPlus.Contract.Messages
{
    [Serializable]
    [DataContract]
    public class OuClinicFirstDTO : DtoBase<int>
    {
        public OuClinicFirstDTO()
        {
        }

        [DataMember]
        public int MzRegId { get; set; }

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
        public string F1 { get; set; }

        [DataMember]
        public string F2 { get; set; }

        [DataMember]
        public string F3 { get; set; }

        [DataMember]
        public string F4 { get; set; }

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

        [DataMember]
        public byte[] Xmlemr { get; set; }

        [DataMember]
        public byte[] XmlCancer { get; set; }

        [DataMember]
        public byte[] XmlSex { get; set; }

        [DataMember]
        public byte[] XmlTuberculosis { get; set; }

        [DataMember]
        public byte[] XmlContagion { get; set; }

        [DataMember]
        public decimal? ExamSugar { get; set; }

        [DataMember]
        public System.DateTime? FirstDate { get; set; }
    }
}
