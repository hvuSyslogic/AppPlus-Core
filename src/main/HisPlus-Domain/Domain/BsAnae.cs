using System.Data.Entity.ModelConfiguration;
using HisPlus.Infrastructure.Contract.Messages;

namespace HisPlus.Domain
{
    public class BsAnae : EntityBase<int>
    {
        public BsAnae()
        {    
        }

        public string Code { get; set; }
        public string Name { get; set; }
        public string FunctionM { get; set; }
        public string Effect { get; set; }
        public string Tabu { get; set; }
        public string Memo { get; set; }
        public string PyCode { get; set; }
        public string WbCode { get; set; }
        public short OrderBy { get; set; }
        public bool IsActive { get; set; }
        public short IconIndex { get; set; }
    }
}
