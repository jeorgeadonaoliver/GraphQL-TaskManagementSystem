using GraphQL.TMS.Application.Contracts;
using GraphQL.TMS.Persistence.Context;
using Microsoft.EntityFrameworkCore;

namespace GraphQL.TMS.Persistence.Repositories
{
    public class GenericRepository<T> : IGenericRepository<T> where T : class
    {
        protected readonly ProjdbContext _context;

        public GenericRepository(ProjdbContext context)
        {
            this._context = context;
        }

        public async Task CreateAsync(T entity)
        {
            _context.Entry(entity).State = EntityState.Added;
            await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(T entity)
        {
            _context.Remove(entity);
            await _context.SaveChangesAsync();
        }

        public async Task<IEnumerable<T>> GetAllAsync()
        {
            return await _context.Set<T>().ToListAsync();
        }

        public async Task UpdateAsync(T entity)
        {
            _context.Update(entity).State = EntityState.Modified;
            await _context.SaveChangesAsync();
        }
    }
}
