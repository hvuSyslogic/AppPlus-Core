using System.Data.Entity.ModelConfiguration;
using AppPlus.Infrastructure.Contract.Messages;

namespace HisPlus.Domain
{
    public class PlProject : EntityBase<int>
    {
        public PlProject()
        {    
        }

        public string Name { get; set; }
        public int ChargeOperId { get; set; }
        public System.DateTime RecTime { get; set; }
        public bool? IsClose { get; set; }
        public string F1 { get; set; }
        public string F2 { get; set; }
        public string F3 { get; set; }
        public string F4 { get; set; }
    }
}
