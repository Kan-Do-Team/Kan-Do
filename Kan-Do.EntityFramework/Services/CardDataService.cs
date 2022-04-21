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
    public class CardDataService : ICardService
    {
        private readonly KanDoDbContextFactory _contextFactory;
        private readonly NonQueryDataService<Card> _nonQueryDataService;

        public CardDataService(KanDoDbContextFactory dbContextFactory)
        {
            _contextFactory = dbContextFactory;
            _nonQueryDataService = new NonQueryDataService<Card>(dbContextFactory);
        }

        public async Task<Card> Create(Card entity)
        {
            return await _nonQueryDataService.Create(entity);
        }

        public async Task<bool> Delete(int id)
        {
            return await _nonQueryDataService.Delete(id);
        }

        public async Task<Card> Get(int id)
        {
            using (KanDoDbContext context = _contextFactory.CreateDbContext())
            {
                Card entity = context.Cards.Include(a => a.Column).ThenInclude(column => column.Board)
                    .ThenInclude(board => board.BoardCreator)
                    .ThenInclude(account => account.AccountHolder)
                    .ToList().FirstOrDefault((e) => e.Id == id);
                return entity;
            }
        }

        public async Task<IEnumerable<Card>> GetAll()
        {
            using (KanDoDbContext context = _contextFactory.CreateDbContext())
            {
                IEnumerable<Card> entities = await context.Cards.Include(a => a.Column.Board.BoardCreator).ToListAsync();
                return entities;
            }
        }

        public async Task<Card> GetByColumnAndDate(int columnId, DateTime dateCreated)
        {
            using (KanDoDbContext context = _contextFactory.CreateDbContext())
            {
                Card entity = context.Cards.Include(a => a.Column).ThenInclude(column => column.Board)
                    .ThenInclude(board => board.BoardCreator)
                    .ThenInclude(account => account.AccountHolder)
                    .ToList().FirstOrDefault((e) => e.DateCreated == dateCreated);
                return entity;
            }
        }

        public async Task<IEnumerable<Card>> GetByUserId(int id)
        {
            using (KanDoDbContext context = _contextFactory.CreateDbContext())
            {
                IEnumerable<Card> entities = await context.Cards.Include(a => a.Column).ThenInclude(column => column.Board)
                    .ThenInclude(board => board.BoardCreator)
                    .ThenInclude(account => account.AccountHolder)
                    .Where(e => e.Column.Board.BoardCreator.AccountHolder.Id == id)
                    .ToListAsync();
                return entities;
            }
        }

        public async Task<Card> Update(int id, Card entity)
        {
            return await _nonQueryDataService.Update(id, entity);
        }
    }
}
