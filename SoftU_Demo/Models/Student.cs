using System.Collections.Generic;

namespace SoftU_WebApp.Models
{
    public class Student : ApplicationUser
    {
        /// <summary>
        /// Староста , или нет
        /// </summary>
        /// <value></value>
        public bool IsHead { get; set; }
        public IEnumerable<Feetback> Feetbacks { get; set; }
    }
}