using System;

namespace SoftU_WebApp.Models
{
    public class ScheduleItem : BaseModel
    {
        public DateTime Start { get; set; }
        public TimeSpan Duration { get; set; }
        public AcademicDiscipline Discipline { get; set; }
    }
}