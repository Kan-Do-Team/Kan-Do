using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kan_Do.WPF.ViewModels.Factories
{
    public class HomeViewModelFactory : IKanDoViewModelFactory<HomeViewModel>
    {
        public HomeViewModel CreateViewModel()
        {
            return new HomeViewModel();
        }
    }
}
