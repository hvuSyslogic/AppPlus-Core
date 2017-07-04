using System.Data.Entity.ModelConfiguration;
using AppPlus.Infrastructure.Contract.Messages;

namespace HisPlus.Domain
{
    public class GblSetting : EntityBase<int>
    {
        public GblSetting()
        {    
        }

        public string KeyNum { get; set; }
        public string SetValue { get; set; }
        public string Explain { get; set; }
    }
}
