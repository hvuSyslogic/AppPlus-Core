using System.Data.Entity.ModelConfiguration;
using HisPlus.Infrastructure.Contract.Messages;

namespace HisPlus.Domain
{
    public class CkCompany : EntityBase<int>
    {
        public CkCompany()
        {    
        }

        public string Code { get; set; }
        public string Name { get; set; }
        public string Phone { get; set; }
        public string Fax { get; set; }
        public string Address { get; set; }
        public string PostCode { get; set; }
        public string PayWayId { get; set; }
        public decimal? Discount { get; set; }
        public string ResponMan { get; set; }
        public string PyCode { get; set; }
        public string WbCode { get; set; }
        public short OrderBy { get; set; }
        public bool IsActive { get; set; }
        public short IconIndex { get; set; }
    }
}
