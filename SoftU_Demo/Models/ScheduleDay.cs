using System.Collections.Generic;

namespace SoftU_WebApp.Models
{
    public class ScheduleDay : BaseModel
    {
        public IEnumerable<ScheduleItem> ScheduleItems { get; set; }
    }
}