using System.Data.Entity.ModelConfiguration;
using AppPlus.Infrastructure.Contract.Messages;

namespace HisPlus.Domain
{
    public class BsPatIll : EntityBase<int>
    {
        public BsPatIll()
        {    
        }

        public int PatId { get; set; }
        public int? IcdId { get; set; }
        public string IllDesc { get; set; }
        public short? LsWestChin { get; set; }
        public System.DateTime? IllTime { get; set; }
        public string ConfirmDoctor { get; set; }
        public short? LsEffect { get; set; }
        public System.DateTime? OperTime { get; set; }
        public int? OperId { get; set; }
        public string F1 { get; set; }
        public string F2 { get; set; }
        public string F3 { get; set; }
        public string F4 { get; set; }
    }
}
