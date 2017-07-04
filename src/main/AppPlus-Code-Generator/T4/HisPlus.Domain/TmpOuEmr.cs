using System.Data.Entity.ModelConfiguration;
using AppPlus.Infrastructure.Contract.Messages;

namespace HisPlus.Domain
{
    public class TmpOuEmr : EntityBase<int>
    {
        public TmpOuEmr()
        {    
        }

        public string Name { get; set; }
        public string GroupMain { get; set; }
        public string GroupSub { get; set; }
        public short? OrderBy { get; set; }
        public bool? IsActive { get; set; }
        public string WbCode { get; set; }
        public string PyCode { get; set; }
        public short? LsOpenType { get; set; }
        public int? OperId { get; set; }
        public System.DateTime? OperTime { get; set; }
        public int? LocationId { get; set; }
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
        public string Impression { get; set; }
        public string Analys { get; set; }
        public string Others { get; set; }
        public string Tongue { get; set; }
        public string Pulse { get; set; }
        public string Moss { get; set; }
    }
}
