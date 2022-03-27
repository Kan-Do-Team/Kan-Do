using Kan_Do.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kan_Do.Domain.Services.AuthenticationServices
{
    public enum RegistrationResult
    {
        Success,
        PasswordsDoNotMatch,
        EmailAlreadyExists
    }
    public interface IAuthenticationService
    {
        Task<RegistrationResult> Register(string firstName, string lastName, string email, string password, string confirmPassword);
        Task<Account> Login(string Email, string password);
    }
}
