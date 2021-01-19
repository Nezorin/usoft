using System;
using System.Collections.Generic;

namespace SoftU_WebApp.Models
{
    public class Homework : BaseModel
    {
        public DateTime DueTo { get; set; }
        public IEnumerable<Material> Materials { get; set; }
    }
}