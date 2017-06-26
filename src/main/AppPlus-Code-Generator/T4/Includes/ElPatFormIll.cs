using AppPlus.Infrastructure.Contract.Messages;
using System.Data.Entity.ModelConfiguration;

namespace HisPlus.Domain
{
    public class ElPatFormIll : EntityBase<int>
    {
        public ElPatFormIll()
        {    
        }

        public int? PatFormId { get; set; }
        public int? ListNum { get; set; }
        public int? IcdId { get; set; }
        public string IllDesc { get; set; }
        public short? LsInOut { get; set; }
        public short? LsWestChin { get; set; }
        public int? Memo { get; set; }
        public string F1 { get; set; }
        public string F2 { get; set; }
        public string F3 { get; set; }
        public string F4 { get; set; }
    }
}
