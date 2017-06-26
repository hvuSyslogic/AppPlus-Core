using AppPlus.Infrastructure.Contract.Messages;
using System.Data.Entity.ModelConfiguration;

namespace HisPlus.Domain
{
    public class NfInfectTestBacteria : EntityBase<int>
    {
        public NfInfectTestBacteria()
        {    
        }

        public int TestId { get; set; }
        public int BacteriaId { get; set; }
        public int? BaseDrugId { get; set; }
        public short? LsResult { get; set; }
        public string F1 { get; set; }
        public string F2 { get; set; }
        public string F3 { get; set; }
        public string F4 { get; set; }
    }
}
