using System.Data.Entity.ModelConfiguration;
using HisPlus.Infrastructure.Contract.Messages;

namespace HisPlus.Domain
{
    public class BsUserWindow : EntityBase<int>
    {
        public BsUserWindow()
        {    
        }

        public int OperId { get; set; }
        public int MenuId { get; set; }
        public string Name { get; set; }
        public string Caption { get; set; }
    }
}
