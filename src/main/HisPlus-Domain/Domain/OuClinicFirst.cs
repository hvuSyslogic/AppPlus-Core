using System.Data.Entity.ModelConfiguration;
using AppPlus.Infrastructure.Contract.Messages;

namespace HisPlus.Domain
{
    public class OuClinicFirst : EntityBase<int>
    {
        public OuClinicFirst()
        {    
        }

        public int MzRegId { get; set; }
        public string MainInform { get; set; }
        public string SickHist { get; set; }
        public decimal? ExamT { get; set; }
        public decimal? ExamP { get; set; }
        public decimal? ExamR { get; set; }
        public decimal? ExamBp { get; set; }
        public decimal? ExamBp2 { get; set; }
        public string CheckUp { get; set; }
        public string CheckCt { get; set; }
        public string Disposal { get; set; }
        public string F1 { get; set; }
        public string F2 { get; set; }
        public string F3 { get; set; }
        public string F4 { get; set; }
        public string Impression { get; set; }
        public string Analys { get; set; }
        public string Others { get; set; }
        public string Tongue { get; set; }
        public string Pulse { get; set; }
        public string Moss { get; set; }
        public byte[] Xmlemr { get; set; }
        public byte[] XmlCancer { get; set; }
        public byte[] XmlSex { get; set; }
        public byte[] XmlTuberculosis { get; set; }
        public byte[] XmlContagion { get; set; }
        public decimal? ExamSugar { get; set; }
        public System.DateTime? FirstDate { get; set; }
    }
}
