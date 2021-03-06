using AppPlus.Infrastructure.Contract.Messages;
using System.Data.Entity.ModelConfiguration;

namespace HisPlus.Domain
{
    public class CkLabDtl : EntityBase<int>
    {
        public CkLabDtl()
        {    
        }

        public int LabId { get; set; }
        public int TestId { get; set; }
        public int? SourceId { get; set; }
        public int? TubeTypeId { get; set; }
        public bool IsDownLoad { get; set; }
        public bool IsPrint { get; set; }
        public System.DateTime? PrintTime { get; set; }
        public int? PrintOperId { get; set; }
        public bool IsBilled { get; set; }
        public string Memo { get; set; }
        public string F1 { get; set; }
        public string F2 { get; set; }
        public string F3 { get; set; }
        public string F4 { get; set; }
        public int? ParentId { get; set; }
        public int? RecipeDtlId { get; set; }
        public int? DetailId { get; set; }
        public string ItemId { get; set; }
    }
}
