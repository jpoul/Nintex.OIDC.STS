namespace Nintex.OIDC.STS.Models.AccountViewModels;

public class LogoutViewModel : LogoutInputModel
{
    public bool ShowLogoutPrompt { get; set; } = true;
}