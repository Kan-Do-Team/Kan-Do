using Kan_Do.Domain.Models;
using Kan_Do.WPF.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kan_Do.WPF.State.SaveState
{
    public interface ISaveState
    {
        Task Save(int accountId, KanbanBoardViewModel kanbanBoardViewModel);
        Task<IEnumerable<Board>> LoadBoards(int accountId);
        Task<IEnumerable<Column>> LoadColumns(int accountId);
        Task<IEnumerable<Card>> LoadCards(int accountId);
        Task<int> AddBoard(KanbanBoardViewModel kanbanBoardViewModel);
    }
}
