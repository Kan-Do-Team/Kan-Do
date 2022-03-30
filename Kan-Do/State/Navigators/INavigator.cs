using Kan_Do.WPF.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Kan_Do.WPF.State.Navigators
{
    public enum ViewType
    {
        Login,
        Home,
        Board
    }

    public interface INavigator
    { 
        ViewModelBase CurrentViewModel { get; set; }
    }
}
