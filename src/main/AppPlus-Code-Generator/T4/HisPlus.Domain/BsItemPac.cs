using System.Data.Entity.ModelConfiguration;
using AppPlus.Infrastructure.Contract.Messages;

namespace HisPlus.Domain
{
    public class BsItemPac : EntityBase<int>
    {
        public BsItemPac()
        {    
        }

        public int ItemId { get; set; }
        public short? XType { get; set; }
        public string Equipment { get; set; }
        public string CheckBody { get; set; }
        public short IconIndex { get; set; }
    }
}
