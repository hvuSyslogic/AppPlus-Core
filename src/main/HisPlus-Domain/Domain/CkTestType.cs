using System.Data.Entity.ModelConfiguration;
using HisPlus.Infrastructure.Contract.Messages;

namespace HisPlus.Domain
{
    public class CkTestType : EntityBase<int>
    {
        public CkTestType()
        {    
        }

        public string Code { get; set; }
        public string Name { get; set; }
        public int TestGroupId { get; set; }
        public bool IsLab { get; set; }
        public string PyCode { get; set; }
        public string WbCode { get; set; }
        public short OrderBy { get; set; }
        public bool IsActive { get; set; }
        public short IconIndex { get; set; }
        public string GroupMain { get; set; }
        public string GroupSub { get; set; }
    }
}
