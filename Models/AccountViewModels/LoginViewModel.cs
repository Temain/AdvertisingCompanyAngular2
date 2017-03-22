using System.ComponentModel.DataAnnotations;

namespace WebApplicationBasic.Models.AccountViewModels
{
    public class LoginViewModel
    {
        [Required(ErrorMessage = "Введите им¤ пользовател¤")]
        public string UserName { get; set; }

        //[Required(ErrorMessage = "Введите адрес электронной почты")]
        //[EmailAddress]
        //public string Email { get; set; }

        [Required(ErrorMessage = "Введите пароль")]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Display(Name = "Remember me?")]
        public bool RememberMe { get; set; }
    }
}
