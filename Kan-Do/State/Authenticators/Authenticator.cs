using Kan_Do.Domain.Models;
using Kan_Do.Domain.Services.AuthenticationServices;
using Kan_Do.WPF.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kan_Do.WPF.State.Authenticators
{
    public class Authenticator : ObservableObject, IAuthenticator
    {
        private readonly IAuthenticationService _authenticationService;

        public Authenticator(IAuthenticationService authenticationService)
        {
            _authenticationService = authenticationService;
        }

        public Account CurrentAccount { get; private set;}
        public bool IsLoggedIn => CurrentAccount != null;

        public event PropertyChangedEventHandler? PropertyChanged;

        public async Task Login(string email, string password)
        {
            CurrentAccount = await _authenticationService.Login(email, password);
            OnPropertyChanged(nameof(IsLoggedIn));
            OnPropertyChanged(nameof(CurrentAccount));

        }

        public void Logout()
        {
            CurrentAccount = null;
            OnPropertyChanged(nameof(IsLoggedIn));
        }

        public async Task<RegistrationResult> Register(string firstName, string lastName, string email, string password, string confirmPassword)
        {
            return await _authenticationService.Register(firstName, lastName, email, password, confirmPassword);
        }
    }
}
