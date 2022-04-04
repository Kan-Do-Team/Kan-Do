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
    public class NavigateToBoard : ICommand
    {

        private readonly INavigator _navigator;

        public NavigateToBoard(INavigator navigator)
        {
            _navigator = navigator;
        }

        public event EventHandler? CanExecuteChanged;

        public bool CanExecute(object? parameter)
        {
            return true;
        }

        public void Execute(object? parameter)
        {
            _navigator.CurrentViewModel = new KanbanBoardViewModel();
        }
    }
}
