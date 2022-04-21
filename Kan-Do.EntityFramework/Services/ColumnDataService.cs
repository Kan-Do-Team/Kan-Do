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
    public class ColumnDataService : IColumnService
    {
        private readonly KanDoDbContextFactory _contextFactory;
        private readonly NonQueryDataService<Column> _nonQueryDataService;

        public ColumnDataService(KanDoDbContextFactory dbContextFactory)
        {
            _contextFactory = dbContextFactory;
            _nonQueryDataService = new NonQueryDataService<Column>(dbContextFactory);
        }

        public async Task<Column> Create(Column entity)
        {
            return await _nonQueryDataService.Create(entity);
        }

        public async Task<bool> Delete(int id)
        {
            return await _nonQueryDataService.Delete(id);
        }

        public async Task<Column> Get(int id)
        {
            using (KanDoDbContext context = _contextFactory.CreateDbContext())
            {
                Column entity = await context.Columns.Include(a => a.Board)
                    .ThenInclude(board => board.BoardCreator)
                    .ThenInclude(account => account.AccountHolder)
                    .FirstOrDefaultAsync((e) => e.Id == id);
                return entity;
            }
        }

        public async Task<IEnumerable<Column>> GetAll()
        {
            using (KanDoDbContext context = _contextFactory.CreateDbContext())
            {
                IEnumerable<Column> entities = await context.Columns.Include(a => a.Board).ToListAsync();
                return entities;
            }
        }

        public async Task<Column> GetByPositionOnBoard(int boardId, int position)
        {
            using (KanDoDbContext context = _contextFactory.CreateDbContext())
            {
                Column entity = context.Columns.Include(a => a.Board)
                    .ThenInclude(board => board.BoardCreator)
                    .ThenInclude(account => account.AccountHolder)
                    .ToList().FirstOrDefault((e) => e.Position == position && e.Board.Id == boardId);
                return entity;
            }
        }

        public async Task<IEnumerable<Column>> GetByUserId(int id)
        {
            using (KanDoDbContext context = _contextFactory.CreateDbContext())
            {
                IEnumerable<Column> entities = await context.Columns.Include(a => a.Board)
                    .ThenInclude(board => board.BoardCreator)
                    .ThenInclude(account => account.AccountHolder)
                    .Where(e => e.Board.BoardCreator.AccountHolder.Id == id)
                    .ToListAsync();
                return entities;
            }
        }

        public async Task<Column> Update(int id, Column entity)
        {
            return await _nonQueryDataService.Update(id, entity);
        }
    }
}
