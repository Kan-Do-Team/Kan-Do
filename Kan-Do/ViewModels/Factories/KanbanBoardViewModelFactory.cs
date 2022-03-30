using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kan_Do.WPF.ViewModels.Factories
{
    public class KanbanBoardViewModelFactory : IKanDoViewModelFactory<KanbanBoardViewModel>
    {
        public KanbanBoardViewModel CreateViewModel()
        {
            return new KanbanBoardViewModel();
        }
    }
}
