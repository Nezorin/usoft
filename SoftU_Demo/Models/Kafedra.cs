using System.Collections.Generic;

namespace WebApp.Models
{
    public class Kafedra : BaseModel
    {
        public IEnumerable<Teacher> Teachers { get; set; }
    }
}