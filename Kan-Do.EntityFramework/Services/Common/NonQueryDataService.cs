using Kan_Do.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kan_Do.EntityFramework.Services.Common
{
    public class NonQueryDataService<T> where T : DomainObject
    {
        private readonly KanDoDbContextFactory _dbContextFactory;

        public NonQueryDataService(KanDoDbContextFactory contextFactory)
        {
            _dbContextFactory = contextFactory;
        }

        public async Task<T> Create(T entity)
        {
            using (KanDoDbContext context = _dbContextFactory.CreateDbContext())
            {
                var entityTrackingState = context.Entry(entity).State;
                if (entity.GetType() != typeof(Account))
                {
                    context.Entry(entity).State = EntityState.Unchanged;
                }
                EntityEntry<T> createdResult = await context.Set<T>().AddAsync(entity);
                await context.SaveChangesAsync();

                return createdResult.Entity;
            }
        }

        public async Task<bool> Delete(int id)
        {
            using (KanDoDbContext context = _dbContextFactory.CreateDbContext())
            {
                T entity = await context.Set<T>().FirstOrDefaultAsync((e) => e.Id == id);
                context.Set<T>().Remove(entity);
                await context.SaveChangesAsync();

                return true;
            }
        }
        public async Task<T> Update(int id, T entity)
        {
            using (KanDoDbContext context = _dbContextFactory.CreateDbContext())
            {
                entity.Id = id;
                context.Set<T>().Update(entity);
                await context.SaveChangesAsync();

                return entity;
            }
        }
    }
}
