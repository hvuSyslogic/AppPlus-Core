using System.Data.Entity.ModelConfiguration;
using HisPlus.Infrastructure.Contract.Messages;

namespace HisPlus.Domain
{
    public class BsUserWord : EntityBase<int>
    {
        public BsUserWord()
        {    
        }

        public int OperId { get; set; }
        public string KeyType { get; set; }
        public string Content { get; set; }
        public short? IconIndex { get; set; }
    }
}
