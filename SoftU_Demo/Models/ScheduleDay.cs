using System.Collections.Generic;

namespace WebApp.Models
{
    public class ScheduleDay : BaseModel
    {
        public IEnumerable<ScheduleItem> ScheduleItems { get; set; }
    }
}