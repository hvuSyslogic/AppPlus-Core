using System.Data.Entity.ModelConfiguration;
using HisPlus.Infrastructure.Contract.Messages;

namespace HisPlus.Domain
{
    public class BsXdGroupDtl : EntityBase<int>
    {
        public BsXdGroupDtl()
        {    
        }

        public int GroupId { get; set; }
        public int XdRpId { get; set; }
        public short OrderBy { get; set; }
        public bool IsActive { get; set; }
        public short LsOpenType { get; set; }
        public int OperId { get; set; }
        public System.DateTime OperTime { get; set; }
        public int LocationId { get; set; }
        public short IconIndex { get; set; }
    }
}
