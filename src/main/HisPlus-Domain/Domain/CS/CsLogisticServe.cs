using AppPlus.Infrastructure.Contract.Messages;
using System.Data.Entity.ModelConfiguration;

namespace HisPlus.Domain
{
    public class CsLogisticServe : EntityBase<int>
    {
        public CsLogisticServe()
        {    
        }

        public string Code { get; set; }
        public string Name { get; set; }
        public string Unit { get; set; }
        public decimal? UnitPrice { get; set; }
        public string F1 { get; set; }
        public string F2 { get; set; }
        public string F3 { get; set; }
        public string F4 { get; set; }
    }
}
