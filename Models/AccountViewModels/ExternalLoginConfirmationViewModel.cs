using System.ComponentModel.DataAnnotations;

namespace WebApplicationBasic.Models.AccountViewModels
{
    public class ExternalLoginConfirmationViewModel
    {
        [Required(ErrorMessage = "Необходимо указать адрес электронной почты")]
        [EmailAddress]
        public string Email { get; set; }

        [Required(ErrorMessage = "Необходимо указать имя пользователя")]
        public string UserName { get; set; }

        public string DisplayName { get; set; }
    }
}
