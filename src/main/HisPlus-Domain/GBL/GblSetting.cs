using AppPlus.Infrastructure.Contract.Messages;
using System.Data.Entity.ModelConfiguration;

namespace HisPlus.Domain
{
    public class GblSetting : EntityBase<int>
    {
        public GblSetting()
        {    
        }

        public string KeyNum { get; set; }
        public string SetValue { get; set; }
        public string F1 { get; set; }
        public string F2 { get; set; }
        public string F3 { get; set; }
        public string F4 { get; set; }
    }
}
