using AppPlus.Infrastructure.Contract.Messages;
using System.Data.Entity.ModelConfiguration;

namespace HisPlus.Domain
{
    public class BsInfection : EntityBase<int>
    {
        public BsInfection()
        {    
        }

        public string Name { get; set; }
        public int Type { get; set; }
        public string F1 { get; set; }
        public string F2 { get; set; }
        public string F3 { get; set; }
        public string F4 { get; set; }
        public bool? Isactive { get; set; }
        public int? Orderby { get; set; }
    }
}
