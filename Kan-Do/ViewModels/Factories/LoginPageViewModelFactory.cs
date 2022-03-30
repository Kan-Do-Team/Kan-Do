using Kan_Do.WPF.State.Authenticators;
using Kan_Do.WPF.State.Navigators;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kan_Do.WPF.ViewModels.Factories
{
    public class LoginPageViewModelFactory : IKanDoViewModelFactory<LoginPageViewModel>
    {
        private readonly IAuthenticator _authenticator;
        private readonly IRenavigator _renavigator;

        public LoginPageViewModelFactory(IAuthenticator authenticator, IRenavigator renavigator)
        {
            _authenticator = authenticator;
            _renavigator = renavigator;
        }

        public LoginPageViewModel CreateViewModel()
        {
            return new LoginPageViewModel(_authenticator, _renavigator);
        }
    }
}
