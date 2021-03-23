using System.ComponentModel.DataAnnotations;

namespace WebApp.ViewModels
{
    public class SignUpViewModel
    {
        [Required]
        [DataType(DataType.EmailAddress)]
        [Display(Name = "Email")]
        public string Email { get; set; }
        [Required]
        [DataType(DataType.Password)]
        [Display(Name = "Пароль")]
        public string Password { get; set; }
        [Required]
        [Display(Name = "FirstName")]
        public string FirstName { get; set; }
        [Required]
        [Display(Name = "MiddleName")]
        public string MiddleName { get; set; }
        [Required]
        [Display(Name = "LastName")]
        public string LastName { get; set; }
        [Required]
        [Display(Name = "Group")]
        public string Group { get; set; } //TODO
        [Required]
        [Display(Name = "Course")]
        public string Course { get; set; }//TODO
        [Required]
        [Display(Name = "Role")]
        public string Role { get; set; }//TODO!!!!!!!!!!!!!
    }
}
