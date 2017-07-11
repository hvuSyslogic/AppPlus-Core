using AppPlus.Infrastructure.Contract.Messages;
using System.Data.Entity.ModelConfiguration;

namespace HisPlus.Domain
{
    public class ElForm : EntityBase<int>
    {
        public ElForm()
        {    
        }

        public int PatMenuId { get; set; }
        public int? ElId { get; set; }
        public string X { get; set; }
        public string Y { get; set; }
        public string Title { get; set; }
        public bool? ReadOnly { get; set; }
        public short? OrderBy { get; set; }
        public bool? IsActive { get; set; }
        public string F1 { get; set; }
        public string F2 { get; set; }
        public string F3 { get; set; }
        public string F4 { get; set; }
    }
}
