using GraphQL.TMS.Domain.ProjDbModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphQL.TMS.Application.Contracts
{
    public interface IEmployeeRepository : IGenericRepository<Employee>
    {
        public Task<IEnumerable<Employee>> GetAllEmployeeAsync();
        public Task<Employee> GetEmployeeByIdAsync(int id);

        public Task<bool> GetAnyAsync(string lastname, string firstname);

        public Task<bool> GetAnyAsync(int id);
    }
}
