using AppPlus.Infrastructure.Contract.Messages;
using System.Data.Entity.ModelConfiguration;

namespace HisPlus.Domain
{
    public class Ckgroupdepartment : EntityBase<int>
    {
        public Ckgroupdepartment()
        {    
        }

        public string Code { get; set; }
        public string Name { get; set; }
        public bool Isactive { get; set; }
        public string Wbcode { get; set; }
        public string Pycode { get; set; }
        public int? Operid { get; set; }
        public System.DateTime? Opertime { get; set; }
        public string F1 { get; set; }
        public string F2 { get; set; }
        public string F3 { get; set; }
        public string F4 { get; set; }
        public int Iconindex { get; set; }
    }
}
