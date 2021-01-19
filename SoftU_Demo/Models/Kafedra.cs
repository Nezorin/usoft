using System.Collections.Generic;

namespace SoftU_WebApp.Models
{
    public class Kafedra : BaseModel
    {
        public IEnumerable<Teacher> Teachers { get; set; }
    }
}