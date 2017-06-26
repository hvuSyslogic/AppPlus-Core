using System.Data.Entity.ModelConfiguration;
using AppPlus.Infrastructure.Contract.Messages;

namespace HisPlus.Domain
{
    public class OuClincDiag : EntityBase<int>
    {
        public OuClincDiag()
        {    
        }

        public int MzRegId { get; set; }
        public int ListNum { get; set; }
        public int? IcdId { get; set; }
        public string IllDesc { get; set; }
        public string F1 { get; set; }
        public string F2 { get; set; }
        public string F3 { get; set; }
        public string F4 { get; set; }
        public short? LsDiagType { get; set; }
        public int? SequenceNum { get; set; }
    }
}
