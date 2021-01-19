using System.Collections.Generic;

namespace SoftU_WebApp.Models
{
    public class University : BaseModel
    {
        public IEnumerable<Faculty> Faculties { get; set; }
    }
}