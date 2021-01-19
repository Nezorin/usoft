using System.Collections.Generic;

namespace SoftU_WebApp.Models
{
    public class Faculty : BaseModel
    {
        public IEnumerable<Group> Groups { get; set; }
    }
}