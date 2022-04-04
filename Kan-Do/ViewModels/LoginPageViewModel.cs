using Kan_Do.WPF.Commands;
using Kan_Do.WPF.State.Authenticators;
using Kan_Do.WPF.State.Navigators;
using Kan_Do.WPF.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Kan_Do.WPF.ViewModels
{
    public class LoginPageViewModel : ViewModelBase
    {
        private string _email;

        public string Email
        {
            get { return _email; }
            set 
            {
                _email = value;
                OnPropertyChanged(nameof(Email));
            }
        }
        public ICommand LoginCommand { get; }

        public LoginPageViewModel(IAuthenticator authenticator, IRenavigator renavigator)
        {
            LoginCommand = new LoginCommand(this, authenticator, renavigator);
        }

    }
}
