using AppPlus.Infrastructure.Contract.Messages;
using System.Data.Entity.ModelConfiguration;

namespace HisPlus.Domain
{
    public class BsMzFeety : EntityBase<int>
    {
        public BsMzFeety()
        {    
        }

        public string Code { get; set; }
        public string Name { get; set; }
        public int? InvItemId { get; set; }
        public string WbCode { get; set; }
        public string PyCode { get; set; }
        public int? LocationId { get; set; }
        public bool IsActive { get; set; }
        public short OrderBy { get; set; }
        public string F1 { get; set; }
        public string F2 { get; set; }
        public string F3 { get; set; }
        public string F4 { get; set; }
        public short IconIndex { get; set; }
    }
}
