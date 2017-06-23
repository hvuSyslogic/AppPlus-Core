using AppPlus.Infrastructure.Contract.Messages;
using System.Data.Entity.ModelConfiguration;

namespace HisPlus.Domain
{
    public class RmGroupPrintNum : EntityBase<int>
    {
        public RmGroupPrintNum()
        {    
        }

        public System.DateTime? PrintDate { get; set; }
        public int? Group1PageNum { get; set; }
        public int? Group2PageNum { get; set; }
        public int? Group3PageNum { get; set; }
        public int? Group4PageNum { get; set; }
        public int? Group5PageNum { get; set; }
        public int? Group6PageNum { get; set; }
        public int? PreviousGroup1PageNum { get; set; }
        public int? PreviousGroup2PageNum { get; set; }
        public int? PreviousGroup3PageNum { get; set; }
        public int? PreviousGroup4PageNum { get; set; }
        public int? PreviousGroup5PageNum { get; set; }
        public int? PreviousGroup6PageNum { get; set; }
        public string F1 { get; set; }
        public string F2 { get; set; }
        public string F3 { get; set; }
        public string F4 { get; set; }
    }
}
