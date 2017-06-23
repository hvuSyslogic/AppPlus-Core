using AppPlus.Infrastructure.Contract.Messages;
using System.Data.Entity.ModelConfiguration;

namespace HisPlus.Domain
{
    public class OuExecuteBack : EntityBase<int>
    {
        public OuExecuteBack()
        {    
        }

        public int ExecuteId { get; set; }
        public int ExecuteDtlId { get; set; }
        public System.DateTime OperTime { get; set; }
        public int OperId { get; set; }
        public bool IsBack { get; set; }
        public string F1 { get; set; }
        public string F2 { get; set; }
        public string F3 { get; set; }
        public string F4 { get; set; }
        public int? KsBackBillId { get; set; }
        public System.DateTime? BackTime { get; set; }
    }
}
