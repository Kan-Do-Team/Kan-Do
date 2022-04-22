using Kan_Do.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kan_Do.Domain.Services
{
    public interface ICardService : IDataService<Card>
    {
        Task<IEnumerable<Card>> GetByUserId(int id);
        Task<Card> GetByColumnAndDate(int columnId, DateTime dateCreated);
        Task<IEnumerable<Card>> GetByBoardId(int id);

    }
}
