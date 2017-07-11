using System.Data.Entity.ModelConfiguration;
using HisPlus.Infrastructure.Contract.Messages;

namespace HisPlus.Domain
{
    public class GblMrk : EntityBase<int>
    {
        public GblMrk()
        {    
        }

        public string MrkFile { get; set; }
        public string MrkContent { get; set; }
        public bool IsActive { get; set; }
    }
}
