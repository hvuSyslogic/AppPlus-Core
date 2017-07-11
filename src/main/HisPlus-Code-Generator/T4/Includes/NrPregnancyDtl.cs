using AppPlus.Infrastructure.Contract.Messages;
using System.Data.Entity.ModelConfiguration;

namespace HisPlus.Domain
{
    public class NrPregnancyDtl : EntityBase<int>
    {
        public NrPregnancyDtl()
        {    
        }

        public int? PregnancyId { get; set; }
        public int? OperId { get; set; }
        public System.DateTime? OperTime { get; set; }
        public decimal? ExamBp { get; set; }
        public decimal? ExamBp2 { get; set; }
        public string Strength { get; set; }
        public string LongTimes { get; set; }
        public string Sometimes { get; set; }
        public string UterusHigh { get; set; }
        public string Post { get; set; }
        public string Speed { get; set; }
        public string Place { get; set; }
        public string FirstHigh { get; set; }
        public string Lengh { get; set; }
        public string Expand { get; set; }
        public string Membrane { get; set; }
        public string Anus { get; set; }
        public string Vagina { get; set; }
        public string Others { get; set; }
        public string CheckMan { get; set; }
        public string CenterTimes { get; set; }
        public string LinkUp { get; set; }
        public string Score { get; set; }
        public string AmniFluid { get; set; }
        public string VaginaBleed { get; set; }
        public string MoveTimes { get; set; }
        public string F1 { get; set; }
        public string F2 { get; set; }
        public string F3 { get; set; }
        public string F4 { get; set; }
    }
}
