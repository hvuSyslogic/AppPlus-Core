using AppPlus.Infrastructure.Contract.Messages;
using System.Data.Entity.ModelConfiguration;

namespace HisPlus.Domain
{
    public class NfInfectTest : EntityBase<int>
    {
        public NfInfectTest()
        {    
        }

        public int InfectId { get; set; }
        public string LabNo { get; set; }
        public int SourceId { get; set; }
        public System.DateTime LabTime { get; set; }
        public string F1 { get; set; }
        public string F2 { get; set; }
        public string F3 { get; set; }
        public string F4 { get; set; }
    }
}
