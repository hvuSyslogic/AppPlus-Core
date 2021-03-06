using AppPlus.Infrastructure.Contract.Messages;
using System.Data.Entity.ModelConfiguration;

namespace HisPlus.Domain
{
    public class BsXdRp : EntityBase<int>
    {
        public BsXdRp()
        {    
        }

        public string Code { get; set; }
        public string Name { get; set; }
        public string GroupMain { get; set; }
        public string GroupSub { get; set; }
        public int? OrderBy { get; set; }
        public bool IsActive { get; set; }
        public string WbCode { get; set; }
        public string PyCode { get; set; }
        public short LsOpenType { get; set; }
        public int OperId { get; set; }
        public System.DateTime OperTime { get; set; }
        public int LocationId { get; set; }
        public string F1 { get; set; }
        public string F2 { get; set; }
        public string F3 { get; set; }
        public string F4 { get; set; }
        public short IconIndex { get; set; }
        public int? TestId { get; set; }
        public short? LsInOut { get; set; }
        public int? ExecLocId { get; set; }
    }
}
