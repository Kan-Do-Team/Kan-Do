using Kan_Do.WPF.State.Authenticators;
using Kan_Do.WPF.State.Navigators;
using Kan_Do.WPF.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Kan_Do.WPF.Commands
{
    namespace Kan_Do.WPF.Commands
    {
        public class LogoutCommand : ICommand
        {
            private readonly MainViewModel _mainViewModel;
            private readonly IAuthenticator _authenticator;
            private readonly IRenavigator _renavigator;

            public LogoutCommand(MainViewModel mainViewModel, IAuthenticator authenticator, IRenavigator renavigator)
            {
                _mainViewModel = mainViewModel;
                _authenticator = authenticator;
                _renavigator = renavigator;
            }

            public event EventHandler? CanExecuteChanged;

            public bool CanExecute(object? parameter)
            {
                return true;
            }

            public void Execute(object? parameter)
            {
                _authenticator.Logout();

                _renavigator.Renavigate();
            }
        }
    }
}
