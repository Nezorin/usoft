using System.Collections.Generic;

namespace WebApp.Models
{
    public class Faculty : BaseModel
    {
        public IEnumerable<Group> Groups { get; set; }
    }
}