using System.Collections.Generic;

namespace WebApp.Models
{
    public class University : BaseModel
    {
        public IEnumerable<Faculty> Faculties { get; set; }
    }
}