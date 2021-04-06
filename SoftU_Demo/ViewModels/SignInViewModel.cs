using System.ComponentModel.DataAnnotations;

namespace WebApp.ViewModels
{
    public class SignInViewModel
    {
        [Required(ErrorMessage = "Введите Логин")]
        [Display(Name = "Email")]
        public string UserName { get; set; }

        [Required(ErrorMessage = "Введите Пароль")]
        [DataType(DataType.Password)]
        [Display(Name = "Пароль")]
        public string Password { get; set; }

        [Display(Name = "Запомнить?")]
        public bool RememberMe { get; set; }
    }
}
