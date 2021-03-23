using System;

namespace WebApp.Models
{
    public class ScheduleItem : BaseModel
    {
        public DateTime Start { get; set; }
        public string Discipline { get; set; }
        public DateTime End { get; set; }
        public string Group { get; set; }
        public string Course { get; set; }
    }
}