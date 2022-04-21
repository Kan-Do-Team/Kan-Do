using Kan_Do.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kan_Do.Domain.Services
{
    public interface IBoardService : IDataService<Board>
    {
        Task<IEnumerable<Board>> GetByUserId(int id);
    }
}
