using System.Data.Entity.ModelConfiguration;
using HisPlus.Infrastructure.Contract.Messages;

namespace HisPlus.Domain
{
    public class BsZyFeety : EntityBase<int>
    {
        public BsZyFeety()
        {    
        }

        public string Code { get; set; }
        public string Name { get; set; }
        public int InvItemId { get; set; }
        public string PyCode { get; set; }
        public string WbCode { get; set; }
        public short OrderBy { get; set; }
        public bool IsActive { get; set; }
        public short IconIndex { get; set; }
        public string CheckType { get; set; }
        public short? CheckOrderby { get; set; }
        public string CheckGroup { get; set; }
    }
}
