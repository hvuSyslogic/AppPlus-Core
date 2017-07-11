using System.Data.Entity.ModelConfiguration;
using HisPlus.Infrastructure.Contract.Messages;

namespace HisPlus.Domain
{
    public class BsItemYb : EntityBase<int>
    {
        public BsItemYb()
        {    
        }

        public int ItemId { get; set; }
        public int TallyGroupId { get; set; }
        public string YbCode { get; set; }
        public string YbDesc { get; set; }
        public short LsYbType { get; set; }
        public short IconIndex { get; set; }
        public short? LsAuthstatus { get; set; }
        public string DrugCode { get; set; }
        public string YblimitCue { get; set; }
    }
}
