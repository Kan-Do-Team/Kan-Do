using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kan_Do.WPF.ViewModels.Factories
{
    public interface IKanDoViewModelFactory<T> where T : ViewModelBase
    {
        T CreateViewModel();
    }
}
