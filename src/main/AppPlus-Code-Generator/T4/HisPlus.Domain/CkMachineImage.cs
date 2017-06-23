using AppPlus.Infrastructure.Contract.Messages;
using System.Data.Entity.ModelConfiguration;

namespace HisPlus.Domain
{
    public class CkMachineImage : EntityBase<int>
    {
        public CkMachineImage()
        {    
        }

        public int LabId { get; set; }
        public string SampleNum { get; set; }
        public int MachineId { get; set; }
        public byte[] LabImage { get; set; }
        public string ImageType { get; set; }
        public bool IsDisplay { get; set; }
        public short OrderBy { get; set; }
    }
}
