using System.Data.Entity.ModelConfiguration;
using AppPlus.Infrastructure.Contract.Messages;

namespace HisPlus.Domain
{
    public class CkProfile : EntityBase<int>
    {
        public CkProfile()
        {    
        }

        public int ProfileId { get; set; }
        public int TestId { get; set; }
        public string F1 { get; set; }
        public string F2 { get; set; }
        public string F3 { get; set; }
        public string F4 { get; set; }
        public int? ItemId { get; set; }
    }
}
