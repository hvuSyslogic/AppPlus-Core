using System.Data.Entity.ModelConfiguration;
using AppPlus.Infrastructure.Contract.Messages;

namespace HisPlus.Domain
{
    public class RdLesson : EntityBase<int>
    {
        public RdLesson()
        {    
        }

        public int LessonTypeId { get; set; }
        public System.DateTime? LessonTime { get; set; }
        public string Location { get; set; }
        public short? Numbers { get; set; }
        public string Company { get; set; }
        public string Occupation { get; set; }
        public string Teacher { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public System.DateTime? OperTime { get; set; }
        public int? OperId { get; set; }
        public string F1 { get; set; }
        public string F2 { get; set; }
        public string F3 { get; set; }
        public string F4 { get; set; }
    }
}
