using System.Data.Entity.ModelConfiguration;
using AppPlus.Infrastructure.Contract.Messages;

namespace HisPlus.Domain
{
    public class BsJcGroupAttach : EntityBase<int>
    {
        public BsJcGroupAttach()
        {    
        }

        public int GroupId { get; set; }
        public int ItemId { get; set; }
        public decimal Totality { get; set; }
        public int? LocationId { get; set; }
        public short LsUseArea { get; set; }
        public string F1 { get; set; }
        public string F2 { get; set; }
        public string F3 { get; set; }
        public string F4 { get; set; }
        public short IconIndex { get; set; }
    }
}
