using AppPlus.Infrastructure.Contract.Messages;

namespace HisPlus.Contract.Messages
{
    public class DdlExecSqlDTO : DtoBase<int>
    {
        public DdlExecSqlDTO()
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
