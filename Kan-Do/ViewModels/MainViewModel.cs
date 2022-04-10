using Kan_Do.WPF.Commands;
using Kan_Do.WPF.State.Authenticators;
using Kan_Do.WPF.State.Navigators;
using Kan_Do.WPF.ViewModels.Factories;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Kan_Do.WPF.ViewModels
{
    public class MainViewModel : ViewModelBase
    {
        private readonly IKanDoViewModelFactory _viewModelFactory;
        public INavigator Navigator { get; set; }
        public IAuthenticator Authenticator { get; }
        public ICommand UpdateCurrentViewModelCommand { get; }
        public ObservableCollection<KanbanBoardViewModel> boardList { get; set; }
        public KanbanBoardViewModel board { get; set; }
        public MainViewModel(INavigator navigator, IKanDoViewModelFactory viewModelFactory, IAuthenticator authenticator)
        {
            boardList = new ObservableCollection<KanbanBoardViewModel>();

            Navigator = navigator;
            _viewModelFactory = viewModelFactory;
            Authenticator = authenticator;

            UpdateCurrentViewModelCommand = new UpdateCurrentViewModelCommand(navigator, _viewModelFactory);
            UpdateCurrentViewModelCommand.Execute(ViewType.Login);
        }

        public void Logout()
        {
            Authenticator.Logout();
        }

        public void AddBoard(KanbanBoardViewModel kanbanBoardViewModel)
        {
            boardList.Add(kanbanBoardViewModel);
        }
    }
}
