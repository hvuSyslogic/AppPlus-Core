using System.Data.Entity.ModelConfiguration;
using HisPlus.Infrastructure.Contract.Messages;

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
        public short? LsDiagType { get; set; }
        public int? SequenceNum { get; set; }
        public string IcdCodeZy { get; set; }
        public string IllDescZy { get; set; }
    }
}
