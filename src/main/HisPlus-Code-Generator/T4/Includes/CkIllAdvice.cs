using AppPlus.Infrastructure.Contract.Messages;
using System.Data.Entity.ModelConfiguration;

namespace HisPlus.Domain
{
    public class CkIllAdvice : EntityBase<int>
    {
        public CkIllAdvice()
        {    
        }

        public int? TestTypeId { get; set; }
        public string Code { get; set; }
        public string IllDesc { get; set; }
        public string OrderBy { get; set; }
        public string Advice { get; set; }
        public string F1 { get; set; }
        public string F2 { get; set; }
        public string F3 { get; set; }
        public string F4 { get; set; }
    }
}
