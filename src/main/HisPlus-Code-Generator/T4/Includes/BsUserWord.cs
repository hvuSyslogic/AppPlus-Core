using AppPlus.Infrastructure.Contract.Messages;
using System.Data.Entity.ModelConfiguration;

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
        public string F1 { get; set; }
        public string F2 { get; set; }
        public string F3 { get; set; }
        public string F4 { get; set; }
        public short? IconIndex { get; set; }
    }
}
