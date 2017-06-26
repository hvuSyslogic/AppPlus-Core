using System.Data.Entity.ModelConfiguration;
using AppPlus.Infrastructure.Contract.Messages;

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
        public string F1 { get; set; }
        public string F2 { get; set; }
        public string F3 { get; set; }
        public string F4 { get; set; }
    }
}
