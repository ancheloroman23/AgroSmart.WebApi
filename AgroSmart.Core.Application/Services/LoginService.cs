using AgroSmart.Core.Application.Dtos.Accounts;
using AgroSmart.Core.Application.Interfaces.Services;
using AgroSmart.Core.Application.ViewModels.Login;
using AutoMapper;

namespace AgroSmart.Core.Application.Services
{
    public class LoginService : ILoginService
    {
        private readonly IMapper _mapper;
        private readonly IAccountService _accountService;

        public LoginService(IAccountService accountService, IMapper mapper)
        {
            _accountService = accountService;
            _mapper = mapper;
        }

        public async Task<string> ConfirmEmailAsync(string userId, string origin)
        {
            return await _accountService.ConfirmAccountAsync(userId, origin);
        }

        public async Task<AuthenticationResponse> LoginAsync(LoginViewModel viewModel)
        {
            AuthenticationRequest authenticationRequest = _mapper.Map<AuthenticationRequest>(viewModel);
            AuthenticationResponse authenticationResponse = await _accountService.AuthenticateWebAppAsync(authenticationRequest);

            //Validacion especifica para los agentes que no se encuntran activos
            if (authenticationResponse.IsActive != true && authenticationResponse.HasError != true)
            {
                authenticationResponse.HasError = true;
                authenticationResponse.Error =
                    $"¡La cuenta con el usuario '{authenticationResponse.UserName}' se encuentra inactiva, comuniquese con un administrador!";
            }

            return authenticationResponse;
        }

        public async Task SignOutAsync()
        {
            await _accountService.SignOutAsync();

        }
    }
}
