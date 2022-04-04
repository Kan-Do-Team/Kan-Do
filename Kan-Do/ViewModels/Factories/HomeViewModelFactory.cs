using Kan_Do.WPF.State.Navigators;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kan_Do.WPF.ViewModels.Factories
{
    public class HomeViewModelFactory : IKanDoViewModelFactory<HomeViewModel>
    {
        private readonly INavigator _navigator;

        public HomeViewModelFactory(INavigator navigator)
        {
            _navigator = navigator;
        }

        public HomeViewModel CreateViewModel()
        {
            return new HomeViewModel(_navigator);
        }
    }
}
