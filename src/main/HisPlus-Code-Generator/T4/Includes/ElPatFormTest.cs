using AppPlus.Infrastructure.Contract.Messages;
using System.Data.Entity.ModelConfiguration;

namespace HisPlus.Domain
{
    public class ElPatFormTest : EntityBase<int>
    {
        public ElPatFormTest()
        {    
        }

        public int PatFormId { get; set; }
        public int TestId { get; set; }
        public string Result { get; set; }
        public string Unit { get; set; }
        public short LsRefFlag { get; set; }
        public decimal LowValue { get; set; }
        public decimal HighValue { get; set; }
        public string Memo { get; set; }
        public System.DateTime OperTime { get; set; }
        public int OperId { get; set; }
        public string TextRange { get; set; }
        public int? LabId { get; set; }
        public string F1 { get; set; }
        public string F2 { get; set; }
        public string F3 { get; set; }
        public string F4 { get; set; }
    }
}
