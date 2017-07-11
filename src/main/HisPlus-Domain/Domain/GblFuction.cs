using System.Data.Entity.ModelConfiguration;
using HisPlus.Infrastructure.Contract.Messages;

namespace HisPlus.Domain
{
    public class GblFuction : EntityBase<int>
    {
        public GblFuction()
        {    
        }

        public int? MenuId { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public string Memo { get; set; }
        public bool? IsTest { get; set; }
        public short? LsClass { get; set; }
        public int OrderBy { get; set; }
        public string Code { get; set; }
    }
}
