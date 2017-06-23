using AppPlus.Infrastructure.Contract.Messages;
using System.Data.Entity.ModelConfiguration;

namespace HisPlus.Domain
{
    public class ReportTable : EntityBase<decimal>
    {
        public ReportTable()
        {    
        }

        public string TabelName { get; set; }
        public string FiledName { get; set; }
        public string FiledZw { get; set; }
        public string FiledType { get; set; }
    }
}
