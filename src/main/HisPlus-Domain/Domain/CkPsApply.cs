using System.Data.Entity.ModelConfiguration;
using AppPlus.Infrastructure.Contract.Messages;

namespace HisPlus.Domain
{
    public class CkPsApply : EntityBase<int>
    {
        public CkPsApply()
        {    
        }

        public string ApplyId { get; set; }
        public int CheckId { get; set; }
        public int ItemId { get; set; }
        public string CheckBody { get; set; }
        public short XType { get; set; }
        public string F1 { get; set; }
        public string F2 { get; set; }
        public string F3 { get; set; }
        public string F4 { get; set; }
    }
}
