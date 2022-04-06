using Kan_Do.WPF.State.Navigators;
using Kan_Do.WPF.ViewModels;
using Kan_Do.WPF.ViewModels.Factories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Kan_Do.WPF.Commands
{
    public class UpdateCurrentViewModelCommand : ICommand
    {
        public event EventHandler? CanExecuteChanged;

        private INavigator _navigator;
        private readonly IKanDoViewModelFactory _viewModelFactory;

        public UpdateCurrentViewModelCommand(INavigator navigator, IKanDoViewModelFactory viewModelFactory)
        {
            _navigator = navigator;
            _viewModelFactory = viewModelFactory;
        }
        
        public bool CanExecute(object? parameter)
        {
            return true;
        }

        public void Execute(object? parameter)
        {
            if(parameter is ViewType)
            {
               ViewType viewType = (ViewType)parameter;

               _navigator.CurrentViewModel = _viewModelFactory.CreateViewModel(viewType);

            }
        }
    }
}
