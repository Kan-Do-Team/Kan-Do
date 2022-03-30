using Kan_Do.WPF.State.Navigators;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kan_Do.WPF.ViewModels.Factories
{
    public class RootKanDoViewModelFactory : IRootKanDoViewModelFactory
    {
        private readonly IKanDoViewModelFactory<HomeViewModel> _homeViewModelFactory;
        private readonly IKanDoViewModelFactory<KanbanBoardViewModel> _kanbanBoardViewModelFactory;
        private readonly IKanDoViewModelFactory<LoginPageViewModel> _loginPageViewModelFactory;

        public RootKanDoViewModelFactory(IKanDoViewModelFactory<HomeViewModel> homeViewModelFactory, IKanDoViewModelFactory<KanbanBoardViewModel> kanbanBoardViewModelFactory, 
            IKanDoViewModelFactory<LoginPageViewModel> loginPageViewModelFactory)
        {
            _homeViewModelFactory = homeViewModelFactory;
            _kanbanBoardViewModelFactory = kanbanBoardViewModelFactory;
            _loginPageViewModelFactory = loginPageViewModelFactory;
        }
        public ViewModelBase CreateViewModel(ViewType viewType)
        {
            switch (viewType)
            {
                case ViewType.Login:
                    return _loginPageViewModelFactory.CreateViewModel();
                case ViewType.Home:
                    return _homeViewModelFactory.CreateViewModel();
                case ViewType.Board:
                    return _kanbanBoardViewModelFactory.CreateViewModel();
                default:
                    throw new ArgumentException("The ViewType does not have a ViewModel.", "ViewType");
            }
        }
    }
}
