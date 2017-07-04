using System.Data.Entity.ModelConfiguration;
using AppPlus.Infrastructure.Contract.Messages;

namespace HisPlus.Domain
{
    public class GblSystemMenu : EntityBase<int>
    {
        public GblSystemMenu()
        {    
        }

        public int SystemId { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public short? IconIndex { get; set; }
        public string Hint { get; set; }
        public string Shortcut { get; set; }
        public int? ParentId { get; set; }
        public short? OrderBy { get; set; }
        public bool? IsMostUsed { get; set; }
        public bool? IsBeginGroup { get; set; }
        public bool? IsActive { get; set; }
        public string DocPath { get; set; }
        public string VideoPath { get; set; }
        public string ReportType { get; set; }
        public bool? IsSelect { get; set; }
    }
}
