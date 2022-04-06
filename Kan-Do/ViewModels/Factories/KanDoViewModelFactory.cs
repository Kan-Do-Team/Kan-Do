using Kan_Do.WPF.State.Navigators;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kan_Do.WPF.ViewModels.Factories
{
    public class KanDoViewModelFactory : IKanDoViewModelFactory
    {
        private readonly CreateViewModel<HomeViewModel> _createHomeViewModelFactory;
        private readonly CreateViewModel<KanbanBoardViewModel> _createKanbanBoardViewModelFactory;
        private readonly CreateViewModel<LoginPageViewModel> _createLoginPageViewModelFactory;

        public KanDoViewModelFactory(CreateViewModel<HomeViewModel> createHomeViewModelFactory, 
            CreateViewModel<KanbanBoardViewModel> createKanbanBoardViewModelFactory, 
            CreateViewModel<LoginPageViewModel> createLoginPageViewModelFactory)
        {
            _createHomeViewModelFactory = createHomeViewModelFactory;
            _createKanbanBoardViewModelFactory = createKanbanBoardViewModelFactory;
            _createLoginPageViewModelFactory = createLoginPageViewModelFactory;
        }

        public ViewModelBase CreateViewModel(ViewType viewType)
        {
            switch (viewType)
            {
                case ViewType.Login:
                    return _createLoginPageViewModelFactory();
                case ViewType.Home:
                    return _createHomeViewModelFactory();
                case ViewType.Board:
                    return _createKanbanBoardViewModelFactory();
                default:
                    throw new ArgumentException("The ViewType does not have a ViewModel.", "ViewType");
            }
        }
    }
}
