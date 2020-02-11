using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Szkolenie.Models;

namespace Szkolenie.Data
{
    public class RepositoryBase<T> : IRepository<T> where T : class
    {
        protected ApplicationDbContext appContext { get; set; }

        public RepositoryBase(ApplicationDbContext applicationDbContext)
        {
            appContext = applicationDbContext;
        }
        public async Task<T> Add(T entity)
        {
            appContext.Set<T>().Add(entity);
            await appContext.SaveChangesAsync();
            return entity;
        }

        public async Task<T> Delete(int id)
        {
            var entity = await appContext.Set<T>().FindAsync(id);
            if (entity == null)
            {
                return entity;
            }

            appContext.Set<T>().Remove(entity);
            await appContext.SaveChangesAsync();

            return entity;
        }

        public async Task<T> Get(int id)
        {
            return await appContext.Set<T>().FindAsync(id);
        }

        public async Task<List<T>> GetAll()
        {
            return await appContext.Set<T>().ToListAsync();
        }

        public async Task<T> Update(T entity)
        {
            appContext.Entry(entity).State = EntityState.Modified;
            await appContext.SaveChangesAsync();
            return entity;
        }
    }
}
