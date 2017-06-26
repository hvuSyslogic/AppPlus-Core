using System.Data.Entity.ModelConfiguration;
using AppPlus.Infrastructure.Contract.Messages;

namespace HisPlus.Domain
{
    public class BsCompany : EntityBase<int>
    {
        public BsCompany()
        {    
        }

        public string Code { get; set; }
        public string Name { get; set; }
        public string CompAddre { get; set; }
        public string CompCorpo { get; set; }
        public string CompPhone { get; set; }
        public string Bank { get; set; }
        public string BankAccount { get; set; }
        public short OrderBy { get; set; }
        public bool IsActive { get; set; }
        public string PyCode { get; set; }
        public string WbCode { get; set; }
        public string F1 { get; set; }
        public string F2 { get; set; }
        public string F3 { get; set; }
        public string F4 { get; set; }
        public short IconIndex { get; set; }
    }
}
