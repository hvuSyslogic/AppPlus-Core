using AppPlus.Infrastructure.Contract.Messages;
using System.Data.Entity.ModelConfiguration;

namespace HisPlus.Domain
{
    public class GblSystemFunction : EntityBase<int>
    {
        public GblSystemFunction()
        {    
        }

        public string Code { get; set; }
        public string Name { get; set; }
        public int OrderBy { get; set; }
        public string F1 { get; set; }
        public string F2 { get; set; }
        public string F3 { get; set; }
        public string F4 { get; set; }
    }
}
