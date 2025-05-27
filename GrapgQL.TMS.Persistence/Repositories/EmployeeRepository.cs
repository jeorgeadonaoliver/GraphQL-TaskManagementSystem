using GraphQL.TMS.Application.Contracts;
using GraphQL.TMS.Domain.ProjDbModels;
using GraphQL.TMS.Persistence.Context;
using Microsoft.EntityFrameworkCore;

namespace GraphQL.TMS.Persistence.Repositories
{
    public class EmployeeRepository : GenericRepository<Employee>, IEmployeeRepository
    {
        public EmployeeRepository(ProjdbContext context): base(context) { }


        public async Task<IEnumerable<Employee>> GetAllEmployeeAsync() 
        {
            return await _context.Set<Employee>()
                 .Include(x => x.Team)
                 .Include(y => y.Department)
                 .Include(z => z.Job)
                 .ToListAsync();
        }

        public async Task<bool> GetAnyAsync(string lastname, string firstname)
        {
            return await _context.Set<Employee>()
                .AnyAsync(x => x.LastName == lastname && x.FirstName == firstname);
        }

        public async Task<bool> GetAnyAsync(int id)
        {
            return await _context.Set<Employee>()
                .AnyAsync(x => x.EmployeeId == id);
        }

        public async Task<Employee> GetEmployeeByIdAsync(int id)
        {
            return await _context.Set<Employee>()
                .Include(x => x.Team)
                .Include(y => y.Department)
                .Include(z => z.Job)
                .SingleOrDefaultAsync(w => w.EmployeeId == id);
        }
    }
}
