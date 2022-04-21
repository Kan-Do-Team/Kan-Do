using Kan_Do.Domain.Models;
using Kan_Do.WPF.Commands;
using Kan_Do.WPF.State.Authenticators;
using Kan_Do.WPF.State.Navigators;
using Kan_Do.WPF.State.SaveState;
using Kan_Do.WPF.ViewModels.Factories;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Kan_Do.WPF.ViewModels
{
    public class MainViewModel : ViewModelBase
    {
        private readonly IKanDoViewModelFactory _viewModelFactory;
        public INavigator Navigator { get; set; }
        public IAuthenticator Authenticator { get; }
        public ISaveState SaveState { get; }
        public ICommand UpdateCurrentViewModelCommand { get; }
        public ObservableCollection<KanbanBoardViewModel> boardList { get; set; }
        public MainViewModel(INavigator navigator, IKanDoViewModelFactory viewModelFactory, IAuthenticator authenticator, ISaveState saveState)
        {
            boardList = new ObservableCollection<KanbanBoardViewModel>();

            Navigator = navigator;
            _viewModelFactory = viewModelFactory;
            Authenticator = authenticator;
            SaveState = saveState;

            UpdateCurrentViewModelCommand = new UpdateCurrentViewModelCommand(navigator, _viewModelFactory);
            UpdateCurrentViewModelCommand.Execute(ViewType.Login);

            Authenticator.LoggingIn += LoadBoards;
        }

        private async void LoadBoards()
        {
            IEnumerable<Board> boards = await SaveState.LoadBoards(Authenticator.CurrentAccount.AccountHolder.Id);
            IEnumerable<Column> columns = await SaveState.LoadColumns(Authenticator.CurrentAccount.AccountHolder.Id);
            IEnumerable<Card> cards = await SaveState.LoadCards(Authenticator.CurrentAccount.AccountHolder.Id);
            KanbanBoardViewModel generatedKanBanBoardViewModel;
            KanbanColumn generatedColumn;
            KanbanCard generatedCard;
            foreach (Board board in boards)
            {
                generatedKanBanBoardViewModel = new KanbanBoardViewModel(Authenticator, SaveState);
                generatedKanBanBoardViewModel.BoardId = board.Id;
                generatedKanBanBoardViewModel.BoardName = board.BoardName;
                generatedKanBanBoardViewModel.cardCount = cards.Count();
                foreach (Column column in columns)
                {
                    if (column.Board.Id == board.Id)
                    {
                        generatedColumn = new KanbanColumn()
                        {
                            ColumnNumber = column.Position,
                            ColumnName = column.ColumnName,
                            ColumnId = column.Position + 1
                        };
                        foreach (Card card in cards)
                        {
                            if (card.Column.Id == column.Id)
                            {
                                generatedCard = new KanbanCard()
                                {
                                    CardID = card.CardReferenceNumber,
                                    CardName = card.CardName,
                                    DateCreated = card.DateCreated,
                                    DueDate = card.DueDate,
                                    Priority = card.Priority,
                                    TaskDescription = card.TaskDescription,
                                    Assignee = card.Assignee,
                                };

                                generatedColumn.column_cards.Add(generatedCard);
                            }
                        }
                        generatedKanBanBoardViewModel.boardColumns.Add(generatedColumn);
                    }
                }
                boardList.Add(generatedKanBanBoardViewModel);
            }
        }

        public void Logout()
        {
            Authenticator.Logout();
            boardList.Clear();
        }

        public async void AddBoard(KanbanBoardViewModel kanbanBoardViewModel)
        {
            int id = await SaveState.AddBoard(kanbanBoardViewModel);
            kanbanBoardViewModel.BoardId = id;
            await SaveState.Save(Authenticator.CurrentAccount.AccountHolder.Id, kanbanBoardViewModel);
            boardList.Add(kanbanBoardViewModel);
        }
    }
}
