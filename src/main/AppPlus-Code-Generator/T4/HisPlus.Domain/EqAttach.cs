using System.Data.Entity.ModelConfiguration;
using AppPlus.Infrastructure.Contract.Messages;

namespace HisPlus.Domain
{
    public class EqAttach : EntityBase<int>
    {
        public EqAttach()
        {    
        }

        public int EquipmentId { get; set; }
        public string FileName { get; set; }
        public string LsFileType { get; set; }
        public byte[] AttachFile { get; set; }
        public string F1 { get; set; }
        public string F2 { get; set; }
        public string F3 { get; set; }
        public string F4 { get; set; }
    }
}
