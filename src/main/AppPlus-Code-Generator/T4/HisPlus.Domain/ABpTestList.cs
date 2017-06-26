using System.Data.Entity.ModelConfiguration;
using AppPlus.Infrastructure.Contract.Messages;

namespace HisPlus.Domain
{
    public class ABpTestList : EntityBase<int>
    {
        public ABpTestList()
        {    
        }

        public string ItemName { get; set; }
        public string Py { get; set; }
        public string Wb { get; set; }
    }
}
