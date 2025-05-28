using GraphQL.TMS.Application.Contracts;
using GraphQL.TMS.Domain.ProjDbModels;
using GraphQL.TMS.Persistence.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphQL.TMS.Persistence.Repositories
{
    public class DepartmentRepository : GenericRepository<Department>, IDepartmentRepository
    {
        public DepartmentRepository(ProjdbContext context): base(context) { }
        
    }
}
