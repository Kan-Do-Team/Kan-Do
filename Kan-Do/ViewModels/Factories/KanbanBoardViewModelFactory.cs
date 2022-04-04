using Kan_Do.WPF.State.Navigators;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kan_Do.WPF.ViewModels.Factories
{
    public class KanbanBoardViewModelFactory : IKanDoViewModelFactory<KanbanBoardViewModel>
    {
        private readonly INavigator _navigator;

        public KanbanBoardViewModelFactory(INavigator navigator)
        {
            _navigator = navigator;
        }
        public KanbanBoardViewModel CreateViewModel()
        {
            return new KanbanBoardViewModel();
        }
    }
}
