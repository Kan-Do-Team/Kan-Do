using Kan_Do.WPF.Commands;
using Kan_Do.WPF.State.Navigators;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Kan_Do.WPF.ViewModels
{
    public class HomeViewModel : ViewModelBase
    {
        public ICommand NavigateToBoard { get; }

        public HomeViewModel(INavigator navigator)
        {
            NavigateToBoard = new NavigateToBoard(navigator);
        }
    }
}
