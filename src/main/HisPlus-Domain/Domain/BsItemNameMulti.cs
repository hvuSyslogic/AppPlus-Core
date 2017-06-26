using System.Data.Entity.ModelConfiguration;
using AppPlus.Infrastructure.Contract.Messages;

namespace HisPlus.Domain
{
    public class BsItemNameMulti : EntityBase<int>
    {
        public BsItemNameMulti()
        {    
        }

        public int ItemId { get; set; }
        public string NameMulti { get; set; }
        public string WbMulti { get; set; }
        public string PyMulti { get; set; }
        public string F1 { get; set; }
        public string F2 { get; set; }
        public string F3 { get; set; }
        public string F4 { get; set; }
    }
}
