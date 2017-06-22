using AppPlus.Infrastructure.Contract.Messages;
using System.Data.Entity.ModelConfiguration;

namespace HisPlus.Domain
{
    public class BsCheckTestList : EntityBase<int>
    {
        public BsCheckTestList()
        {    
        }

        public int? IllId { get; set; }
        public string IllName { get; set; }
        public string GroupType { get; set; }
        public string CheckTestType { get; set; }
        public int? ItemId { get; set; }
        public string ItemName { get; set; }
        public string ItemDesc { get; set; }
        public string ItemResult { get; set; }
    }
}
