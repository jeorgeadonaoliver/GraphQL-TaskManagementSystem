using GraphQL.TMS.Application.Contracts;
using GraphQL.TMS.Application.Extensions;
using GraphQL.TMS.Application.Features.DepartmentManagement.Query.GetAllDepartment;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphQL.TMS.Application.Features.JopManagement.Query.GetAllJob
{
    public class GetAllJobQueryHandler : IRequestHandler<GetAllDepartmentQuery, List<GetAllDepartmentQueryDto>>
    {
        IDepartmentRepository _repository;
        public GetAllJobQueryHandler(IDepartmentRepository repository)
        {
            _repository = repository;
        }

        public async Task<List<GetAllDepartmentQueryDto>> Handle(GetAllDepartmentQuery request, CancellationToken cancellationToken)
        {
            var data = await _repository.GetAllAsync();
            return data.Select(x => x.MapToGetAllDepartmentQueryDto()).ToList();
        }
    }
}
