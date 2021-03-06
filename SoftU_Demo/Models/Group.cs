using System.Collections.Generic;
namespace WebApp.Models
{
    public class Group : BaseModel
    {
        IEnumerable<Student> Students { get; set; }
    }
}