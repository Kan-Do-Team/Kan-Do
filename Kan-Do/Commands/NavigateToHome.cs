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
    public class NavigateToHome : ICommand
    {

        private readonly INavigator _navigator;
        private readonly KanbanBoardViewModel _kanbanBoardViewModel;

        public NavigateToHome(KanbanBoardViewModel kanbanBoardViewModel, INavigator navigator)
        {
            _navigator = navigator;
            _kanbanBoardViewModel = kanbanBoardViewModel;
        }

        public event EventHandler? CanExecuteChanged;

        public bool CanExecute(object? parameter)
        {
            return true;
        }

        public void Execute(object? parameter)
        {
            _navigator.CurrentBoardViewModel = _kanbanBoardViewModel;
            _navigator.CurrentViewModel = _navigator.CurrentHomeViewModel;
        }
    }
}
