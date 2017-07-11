using AppPlus.Infrastructure.Contract.Messages;
using System.Data.Entity.ModelConfiguration;

namespace HisPlus.Domain
{
    public class FtMain : EntityBase<int>
    {
        public FtMain()
        {    
        }

        public string CheckNo { get; set; }
        public int? UserId { get; set; }
        public int? HospId { get; set; }
        public int? LocationId { get; set; }
        public int OperId { get; set; }
        public System.DateTime OperTime { get; set; }
        public string Memo { get; set; }
        public bool? IsPrint { get; set; }
        public bool IsConfirm { get; set; }
        public System.DateTime? ConfirmOperTime { get; set; }
        public int? ConfirmOperId { get; set; }
        public string F1 { get; set; }
        public string F2 { get; set; }
        public string F3 { get; set; }
        public string F4 { get; set; }
    }
}
