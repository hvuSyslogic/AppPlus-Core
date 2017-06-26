using System.Data.Entity.ModelConfiguration;
using AppPlus.Infrastructure.Contract.Messages;

namespace HisPlus.Domain
{
    public class OuNotAttach : EntityBase<int>
    {
        public OuNotAttach()
        {    
        }

        public int MzRegId { get; set; }
        public int ItemId1 { get; set; }
        public int ItemId2 { get; set; }
        public string F1 { get; set; }
        public string F2 { get; set; }
        public string F3 { get; set; }
        public string F4 { get; set; }
    }
}
