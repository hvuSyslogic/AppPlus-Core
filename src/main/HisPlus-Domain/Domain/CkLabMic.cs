using System.Data.Entity.ModelConfiguration;
using AppPlus.Infrastructure.Contract.Messages;

namespace HisPlus.Domain
{
    public class CkLabMic : EntityBase<int>
    {
        public CkLabMic()
        {    
        }

        public int LabId { get; set; }
        public int BacteriaId { get; set; }
        public string Memo { get; set; }
        public System.DateTime OperTime { get; set; }
        public int OperId { get; set; }
        public bool IsPrint { get; set; }
        public System.DateTime? PrintTime { get; set; }
        public int? PrintOperId { get; set; }
        public string F1 { get; set; }
        public string F2 { get; set; }
        public string F3 { get; set; }
        public string F4 { get; set; }
    }
}
