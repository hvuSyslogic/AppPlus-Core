using AppPlus.Infrastructure.Contract.Messages;
using System.Data.Entity.ModelConfiguration;

namespace HisPlus.Domain
{
    public class BsItemFirstPage : EntityBase<int>
    {
        public BsItemFirstPage()
        {    
        }

        public int ItemId { get; set; }
        public int? PsFeeId { get; set; }
        public string F1 { get; set; }
        public string F2 { get; set; }
        public string F3 { get; set; }
        public string F4 { get; set; }
    }
}
