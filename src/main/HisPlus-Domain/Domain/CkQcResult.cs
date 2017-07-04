using System.Data.Entity.ModelConfiguration;
using AppPlus.Infrastructure.Contract.Messages;

namespace HisPlus.Domain
{
    public class CkQcResult : EntityBase<int>
    {
        public CkQcResult()
        {    
        }

        public System.DateTime ResultDate { get; set; }
        public string Result { get; set; }
        public string ResultComment { get; set; }
        public int OperId { get; set; }
        public string ResultStatus { get; set; }
        public int LotId { get; set; }
        public int TestId { get; set; }
        public int CtrlId { get; set; }
        public bool? IsShowQc { get; set; }
        public string RejectMemo { get; set; }
    }
}
