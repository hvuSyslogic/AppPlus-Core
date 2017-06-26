using System.Data.Entity.ModelConfiguration;
using AppPlus.Infrastructure.Contract.Messages;

namespace HisPlus.Domain
{
    public class GblFunDemo : EntityBase<int>
    {
        public GblFunDemo()
        {    
        }

        public string Purpose { get; set; }
        public int? FuntionId { get; set; }
        public string Memo { get; set; }
        public int? OrderBy { get; set; }
        public string F1 { get; set; }
        public string F2 { get; set; }
        public string F3 { get; set; }
        public string F4 { get; set; }
    }
}
