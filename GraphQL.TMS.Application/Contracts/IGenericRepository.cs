using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphQL.TMS.Application.Contracts
{
    public interface IGenericRepository<T>
    {
        public Task<IEnumerable<T>> GetAllAsync();

        public Task CreateAsync(T entity);

        public Task DeleteAsync(T entity);

        public Task UpdateAsync(T entity);
    }
}
