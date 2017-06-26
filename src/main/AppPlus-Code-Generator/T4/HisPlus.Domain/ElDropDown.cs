using System.Data.Entity.ModelConfiguration;
using AppPlus.Infrastructure.Contract.Messages;

namespace HisPlus.Domain
{
    public class ElDropDown : EntityBase<int>
    {
        public ElDropDown()
        {    
        }

        public int? ElId { get; set; }
        public string Name { get; set; }
        public short? OrderBy { get; set; }
        public bool? IsActive { get; set; }
        public string F1 { get; set; }
        public string F2 { get; set; }
        public string F3 { get; set; }
        public string F4 { get; set; }
    }
}
