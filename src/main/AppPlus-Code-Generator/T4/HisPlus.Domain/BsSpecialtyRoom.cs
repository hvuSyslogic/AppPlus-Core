using System.Data.Entity.ModelConfiguration;
using AppPlus.Infrastructure.Contract.Messages;

namespace HisPlus.Domain
{
    public class BsSpecialtyRoom : EntityBase<int>
    {
        public BsSpecialtyRoom()
        {    
        }

        public string Code { get; set; }
        public string Name { get; set; }
        public int? Hospitalid { get; set; }
        public int? Locationid { get; set; }
        public string Wbcode { get; set; }
        public string Pycode { get; set; }
        public int Orderby { get; set; }
        public int Isactive { get; set; }
        public int Iconindex { get; set; }
    }
}
