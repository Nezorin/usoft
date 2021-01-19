using System.Collections.Generic;
namespace SoftU_WebApp.Models
{
    public class Group : BaseModel
    {
        IEnumerable<Student> Students { get; set; }
    }
}