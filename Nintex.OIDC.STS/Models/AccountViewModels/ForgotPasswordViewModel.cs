using System.ComponentModel.DataAnnotations;

namespace Nintex.OIDC.STS.Models.AccountViewModels;

public class ForgotPasswordViewModel
{
    [Required(ErrorMessage = "EMAIL_REQUIRED")]
    [EmailAddress(ErrorMessage = "EMAIL_INVALID")]
    public string Email { get; set; }
}