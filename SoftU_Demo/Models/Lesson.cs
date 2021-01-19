using System;
using System.Collections.Generic;

namespace SoftU_WebApp.Models
{
    public class Lesson : BaseModel
    {
        public DateTime Start { get; set; }
        public DateTime End { get; set; }
        public string Topic { get; set; }
        public IEnumerable<Homework> MyProperty { get; set; }
    }
}