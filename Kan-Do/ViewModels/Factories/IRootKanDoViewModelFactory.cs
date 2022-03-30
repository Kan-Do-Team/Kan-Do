using Kan_Do.WPF.State.Navigators;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kan_Do.WPF.ViewModels.Factories
{
    public interface IRootKanDoViewModelFactory
    {
        public ViewModelBase CreateViewModel(ViewType viewType);
    }
}
