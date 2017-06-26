using System.Data.Entity.ModelConfiguration;
using AppPlus.Infrastructure.Contract.Messages;

namespace HisPlus.Domain
{
    public class BsItemPerson : EntityBase<int>
    {
        public BsItemPerson()
        {    
        }

        public int ItemId { get; set; }
        public int UserId { get; set; }
        public int? PatId { get; set; }
        public System.DateTime? FromTime { get; set; }
        public System.DateTime? ToTime { get; set; }
        public bool? IsExcept { get; set; }
        public string Memo { get; set; }
        public string F1 { get; set; }
        public string F2 { get; set; }
        public string F3 { get; set; }
        public string F4 { get; set; }
    }
}
