using Kan_Do.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kan_Do.Domain.Services
{
    public interface IColumnService : IDataService<Column>
    {
        Task<IEnumerable<Column>> GetByUserId(int id);
        Task<Column> GetByPositionOnBoard(int boardId, int position);
        Task<IEnumerable<Column>> GetByBoardId(int id);
    }
}
