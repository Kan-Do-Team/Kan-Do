using Kan_Do.Domain.Models;
using Kan_Do.Domain.Services;
using Kan_Do.WPF.Models;
using Kan_Do.WPF.ViewModels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kan_Do.WPF.State.SaveState
{
    public class SaveState : ObservableObject, ISaveState
    {
        private readonly ISaveStateService _saveStateService;

        public SaveState(ISaveStateService saveStateService)
        {
            _saveStateService = saveStateService;
        }

        public event PropertyChangedEventHandler? PropertyChanged;

        public async Task<IEnumerable<Board>> LoadBoards(int accountId)
        {
            return await _saveStateService.LoadBoards(accountId);
        }

        public async Task<IEnumerable<Card>> LoadCards(int accountId)
        {
            return await _saveStateService.LoadCards(accountId);
        }

        public async Task<IEnumerable<Column>> LoadColumns(int accountId)
        {
            return await _saveStateService.LoadColumns(accountId);
        }

        public async Task Save(int accountId, KanbanBoardViewModel kanbanBoardViewModel)
        {
            await _saveStateService.Save(accountId, kanbanBoardViewModel.BoardId, kanbanBoardViewModel.BoardName, kanbanBoardViewModel.boardColumns);
        }

        public async Task<int> AddBoard(KanbanBoardViewModel kanbanBoardViewModel)
        {
            int id = await _saveStateService.AddBoard(kanbanBoardViewModel.BoardName, kanbanBoardViewModel.Authenticator.CurrentAccount);
            return id;
        }
    }
}
