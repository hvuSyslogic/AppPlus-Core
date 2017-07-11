using System.Data.Entity.ModelConfiguration;
using HisPlus.Infrastructure.Contract.Messages;

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
        public short? Piority { get; set; }
        public string Basetable { get; set; }
        public bool? IsMutiselect { get; set; }
        public int? SystemId { get; set; }
        public System.DateTime? ModiTime { get; set; }
        public int? ModiOperId { get; set; }
    }
}
