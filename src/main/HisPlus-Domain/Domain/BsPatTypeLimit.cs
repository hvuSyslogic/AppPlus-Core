using System.Data.Entity.ModelConfiguration;
using AppPlus.Infrastructure.Contract.Messages;

namespace HisPlus.Domain
{
    public class BsPatTypeLimit : EntityBase<int>
    {
        public BsPatTypeLimit()
        {    
        }

        public int PatTypeId { get; set; }
        public int DocLevId { get; set; }
        public int? LimitGroupId { get; set; }
        public string F1 { get; set; }
        public string F2 { get; set; }
        public string F3 { get; set; }
        public string F4 { get; set; }
        public short IconIndex { get; set; }
    }
}
