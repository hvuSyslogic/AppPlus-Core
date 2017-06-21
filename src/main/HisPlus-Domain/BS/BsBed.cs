using AppPlus.Infrastructure.Contract.Messages;
using System.Data.Entity.ModelConfiguration;

namespace HisPlus.Domain
{
    public class BsBed : EntityBase<int>
    {
        public BsBed()
        {    
        }

        public string Name { get; set; }
        public string RoomNo { get; set; }
        public int LocationId { get; set; }
        public short LsBall { get; set; }
        public int? ItemId { get; set; }
        public bool IsAdd { get; set; }
        public string Memo { get; set; }
        public int OperId { get; set; }
        public System.DateTime OperTime { get; set; }
        public short OrderBy { get; set; }
        public bool IsActive { get; set; }
        public string F1 { get; set; }
        public string F2 { get; set; }
        public string F3 { get; set; }
        public string F4 { get; set; }
        public short IconIndex { get; set; }
        public short LsClass { get; set; }
        public bool? IsAddBed { get; set; }
    }
}
