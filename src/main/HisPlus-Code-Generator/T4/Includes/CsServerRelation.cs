using AppPlus.Infrastructure.Contract.Messages;
using System.Data.Entity.ModelConfiguration;

namespace HisPlus.Domain
{
    public class CsServerRelation : EntityBase<int>
    {
        public CsServerRelation()
        {    
        }

        public int SeverLocId { get; set; }
        public int BenefitLocId { get; set; }
        public string F1 { get; set; }
        public string F2 { get; set; }
        public string F3 { get; set; }
        public string F4 { get; set; }
    }
}
