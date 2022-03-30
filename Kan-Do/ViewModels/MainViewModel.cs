using Kan_Do.WPF.Commands;
using Kan_Do.WPF.State.Authenticators;
using Kan_Do.WPF.State.Navigators;
using Kan_Do.WPF.ViewModels.Factories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Kan_Do.WPF.ViewModels
{
    public class MainViewModel : ViewModelBase
    {
        private readonly IRootKanDoViewModelFactory _viewModelFactory;
        public INavigator Navigator { get; set; }
        public IAuthenticator Authenticator { get; }
        public ICommand UpdateCurrentViewModelCommand { get; }
        public MainViewModel(INavigator navigator, IRootKanDoViewModelFactory viewModelFactory, IAuthenticator authenticator)
        {
            Navigator = navigator;
            _viewModelFactory = viewModelFactory;
            Authenticator = authenticator;

            UpdateCurrentViewModelCommand = new UpdateCurrentViewModelCommand(navigator, _viewModelFactory);
            UpdateCurrentViewModelCommand.Execute(ViewType.Login);
        }
    }
}
