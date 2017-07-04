using System.Data.Entity.ModelConfiguration;
using AppPlus.Infrastructure.Contract.Messages;

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
        public int? KsBackBillId { get; set; }
        public System.DateTime? BackTime { get; set; }
    }
}
