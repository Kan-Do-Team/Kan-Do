using Kan_Do.Domain.Exceptions;
using Kan_Do.Domain.Models;
using Microsoft.AspNet.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kan_Do.Domain.Services.AuthenticationServices
{
    public class AuthenticationService : IAuthenticationService
    {
        private readonly IAccountService _accountService;
        private readonly IPasswordHasher _passwordHasher = new PasswordHasher();
        public AuthenticationService(IAccountService accountService, IPasswordHasher passwordHasher)
        {
            _accountService = accountService;
            _passwordHasher = passwordHasher;
        }

        public async Task<Account> Login(string email, string password)
        {
            Account storedAccount = await _accountService.GetByEmail(email);

            PasswordVerificationResult passwordsResult = _passwordHasher.VerifyHashedPassword(storedAccount.AccountHolder.PasswordHash, password);

            if (passwordsResult != PasswordVerificationResult.Success)
            {
                throw new InvalidPasswordException(email, password);
            }
            return storedAccount;
        }

        public async Task<RegistrationResult> Register(string firstName, string lastName, string email, string password, string confirmPassword)
        {
            RegistrationResult result = RegistrationResult.Success;

            if (password != confirmPassword)
            {
                result = RegistrationResult.PasswordsDoNotMatch;
            }
                                
            Account emailAccount = await _accountService.GetByEmail(email);

            if(emailAccount != null)
            {
                result = RegistrationResult.EmailAlreadyExists;
            }

            if(result == RegistrationResult.Success)
            {
                string hashedPassword = _passwordHasher.HashPassword(password);

                User user = new User()
                {
                    Email = email,
                    FirstName = firstName,
                    LastName = lastName,
                    PasswordHash = hashedPassword,
                    DateJoined = DateTime.UtcNow,
                };

                Account account = new Account()
                {
                    AccountHolder = user,
                };

                await _accountService.Create(account);
            }
                              
            return result;
        }
    }
}
