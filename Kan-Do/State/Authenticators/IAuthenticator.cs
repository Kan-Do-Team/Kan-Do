using Kan_Do.Domain.Models;
using Kan_Do.Domain.Services.AuthenticationServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kan_Do.WPF.State.Authenticators
{
    public interface IAuthenticator
    {
        Account CurrentAccount { get; }
        bool IsLoggedIn { get; }

        Task<RegistrationResult> Register(string firstName, string lastName, string email, string password, string confirmPassword);
        Task Login(string email, string password);
        void Logout();
    }
}
