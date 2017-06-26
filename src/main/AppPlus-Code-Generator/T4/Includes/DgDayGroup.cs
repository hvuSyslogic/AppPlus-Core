using AppPlus.Infrastructure.Contract.Messages;
using System.Data.Entity.ModelConfiguration;

namespace HisPlus.Domain
{
    public class DgDayGroup : EntityBase<int>
    {
        public DgDayGroup()
        {    
        }

        public string Code { get; set; }
        public string Name { get; set; }
        public string F1 { get; set; }
        public string F2 { get; set; }
        public string F3 { get; set; }
        public string F4 { get; set; }
        public short IconIndex { get; set; }
        public short? Days { get; set; }
    }
}
