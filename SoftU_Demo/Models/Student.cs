using System.ComponentModel.DataAnnotations;

namespace SoftU_WebApp.Models
{
    public class Student /*: ApplicationUser*/
    {
        /// <summary>
        /// Староста , или нет
        /// </summary>
        /// <value></value>
        /// 
        public long Id { get; set; }
        public bool IsHead { get; set; }
        [Required]
        [Display(Name = "Login")]
        public string Login { get; set; }
        [Required]
        [DataType(DataType.Password)]
        [Display(Name = "Password")]
        public string Password { get; set; }
        //public IEnumerable<Feetback> Feetbacks { get; set; }
    }
}