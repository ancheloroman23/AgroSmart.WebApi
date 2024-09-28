using AgroSmart.Core.Application.Dtos.Accounts;
using AgroSmart.Core.Application.ViewModels.Login;

namespace AgroSmart.Core.Application.Interfaces.Services
{
    public interface ILoginService
    {
        Task<string> ConfirmEmailAsync(string userId, string origin);
        Task<AuthenticationResponse> LoginAsync(LoginViewModel viewModel);
        Task SignOutAsync();
    }
}
