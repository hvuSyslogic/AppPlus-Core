using AppPlus.Infrastructure.Contract.Messages;
using System.Data.Entity.ModelConfiguration;

namespace HisPlus.Domain
{
    public class DgTabu : EntityBase<int>
    {
        public DgTabu()
        {    
        }

        public int DrugId { get; set; }
        public int DrugId1 { get; set; }
        public int? DrugId2 { get; set; }
        public int? DrugId3 { get; set; }
        public int? DrugId4 { get; set; }
        public string LClass { get; set; }
        public string Expain { get; set; }
        public string F1 { get; set; }
        public string F2 { get; set; }
        public string F3 { get; set; }
        public string F4 { get; set; }
    }
}
