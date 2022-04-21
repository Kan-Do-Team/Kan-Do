using Kan_Do.Domain.Models;
using Kan_Do.Domain.Services;
using Kan_Do.EntityFramework.Services.Common;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kan_Do.EntityFramework.Services
{
    public class BoardDataService : IBoardService
    {
        private readonly KanDoDbContextFactory _contextFactory;
        private readonly NonQueryDataService<Board> _nonQueryDataService;

        public BoardDataService(KanDoDbContextFactory dbContextFactory)
        {
            _contextFactory = dbContextFactory;
            _nonQueryDataService = new NonQueryDataService<Board>(dbContextFactory);
        }

        public async Task<Board> Create(Board entity)
        {
            return await _nonQueryDataService.Create(entity);
        }

        public async Task<bool> Delete(int id)
        {
            return await _nonQueryDataService.Delete(id);
        }

        public async Task<Board> Get(int id)
        {
            using (KanDoDbContext context = _contextFactory.CreateDbContext())
            {
                Board entity = context.Boards.Include(a => a.BoardCreator)
                    .ThenInclude(user => user.AccountHolder)
                    .ToList().FirstOrDefault(e => e.Id == id);
                return entity;
            }
        }

        public async Task<IEnumerable<Board>> GetAll()
        {
            using (KanDoDbContext context = _contextFactory.CreateDbContext())
            {
                IEnumerable<Board> entities = await context.Boards.Include(a => a.BoardCreator)
                    .ThenInclude(user => user.AccountHolder).ToListAsync();
                return entities;
            }
        }

        public async Task<IEnumerable<Board>> GetByUserId(int id)
        {
            using (KanDoDbContext context = _contextFactory.CreateDbContext())
            {
                IEnumerable<Board> entities = await context.Boards
                    .Include(a => a.BoardCreator)
                    .ThenInclude(user => user.AccountHolder)
                    .Where(e => e.BoardCreator.AccountHolder.Id == id)
                    .ToListAsync();
                return entities;
            }
        }

        public async Task<Board> Update(int id, Board entity)
        {
            return await _nonQueryDataService.Update(id, entity);
        }
    }
}
