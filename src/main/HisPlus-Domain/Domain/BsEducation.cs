using System.Data.Entity.ModelConfiguration;
using HisPlus.Infrastructure.Contract.Messages;

namespace HisPlus.Domain
{
    public class BsEducation : EntityBase<int>
    {
        public BsEducation()
        {    
        }

        public string Code { get; set; }
        public string Name { get; set; }
        public string GroupMain { get; set; }
        public string GroupSub { get; set; }
        public string Content { get; set; }
        public string PyCode { get; set; }
        public string WbCode { get; set; }
        public short OrderBy { get; set; }
        public bool IsActive { get; set; }
        public short IconIndex { get; set; }
    }
}
