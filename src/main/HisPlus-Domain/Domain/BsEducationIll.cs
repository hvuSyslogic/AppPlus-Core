using System.Data.Entity.ModelConfiguration;
using HisPlus.Infrastructure.Contract.Messages;

namespace HisPlus.Domain
{
    public class BsEducationIll : EntityBase<int>
    {
        public BsEducationIll()
        {    
        }

        public int EducationId { get; set; }
        public int ListNum { get; set; }
        public int? IcdId { get; set; }
        public string IllDesc { get; set; }
    }
}
