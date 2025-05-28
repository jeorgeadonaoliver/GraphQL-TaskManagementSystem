using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphQL.TMS.Application.Features.DepartmentManagement.Query.GetAllDepartment
{
    public record GetAllDepartmentQuery : IRequest<List<GetAllDepartmentQueryDto>>;

}
