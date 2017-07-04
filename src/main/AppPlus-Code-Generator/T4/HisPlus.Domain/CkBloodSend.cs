using System.Data.Entity.ModelConfiguration;
using AppPlus.Infrastructure.Contract.Messages;

namespace HisPlus.Domain
{
    public class CkBloodSend : EntityBase<int>
    {
        public CkBloodSend()
        {    
        }

        public string RecNo { get; set; }
        public int LabId { get; set; }
        public int BloodId { get; set; }
        public System.DateTime NoteTime { get; set; }
        public int NoteOperId { get; set; }
        public bool? IsSend { get; set; }
        public System.DateTime? SendTime { get; set; }
        public int? SendOperId { get; set; }
        public string TakeMan { get; set; }
        public string Memo { get; set; }
        public System.DateTime? OperTime { get; set; }
        public int? OperId { get; set; }
    }
}
