using Kan_Do.Domain.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kan_Do.Domain.Services
{
    public interface ISaveStateService
    {
        Task Save(int accountId, int boardId, string boardName, ObservableCollection<KanbanColumn> boardColumns);
        Task<IEnumerable<Board>> LoadBoards(int accountId);
        Task<IEnumerable<Column>> LoadColumns(int accountId);
        Task<IEnumerable<Card>> LoadCards(int accountId);
        Task<int> AddBoard(string boardName, Account currentAccount);
    }
}
