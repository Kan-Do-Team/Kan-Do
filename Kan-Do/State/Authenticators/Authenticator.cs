using Kan_Do.Domain.Models;
using Kan_Do.Domain.Services.AuthenticationServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kan_Do.WPF.State.Authenticators
{
    public class Authenticator : IAuthenticator
    {
        private readonly IAuthenticationService _authenticationService;

        public Authenticator(IAuthenticationService authenticationService)
        {
            _authenticationService = authenticationService;
        }

        public Account CurrentAccount { get; private set;}
        public bool IsLoggedIn => CurrentAccount != null;

        public async Task Login(string email, string password)
        {
                CurrentAccount = await _authenticationService.Login(email, password);
        }

        public void Logout()
        {
            CurrentAccount = null;
        }

        public async Task<RegistrationResult> Register(string firstName, string lastName, string email, string password, string confirmPassword)
        {
            return await _authenticationService.Register(firstName, lastName, email, password, confirmPassword);
        }
    }
}
