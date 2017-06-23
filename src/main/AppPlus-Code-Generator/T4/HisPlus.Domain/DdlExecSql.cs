using AppPlus.Infrastructure.Contract.Messages;
using System.Data.Entity.ModelConfiguration;

namespace HisPlus.Domain
{
    public class DdlExecSql : EntityBase<int>
    {
        public DdlExecSql()
        {    
        }

        public string EventType { get; set; }
        public string SchemaName { get; set; }
        public string ObjType { get; set; }
        public string ObjName { get; set; }
        public string SqlText { get; set; }
        public System.DateTime? ExecDate { get; set; }
        public string Terminal { get; set; }
    }
}
