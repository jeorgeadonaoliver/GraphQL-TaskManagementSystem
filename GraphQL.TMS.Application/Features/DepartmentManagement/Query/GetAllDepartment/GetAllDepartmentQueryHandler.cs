using GraphQL.TMS.Application.Contracts;
using GraphQL.TMS.Application.Extensions;
using MediatR;

namespace GraphQL.TMS.Application.Features.DepartmentManagement.Query.GetAllDepartment
{
    public class GetAllDepartmentQueryHandler : IRequestHandler<GetAllDepartmentQuery, List<GetAllDepartmentQueryDto>>
    {
        IDepartmentRepository _repository;
        public GetAllDepartmentQueryHandler(IDepartmentRepository repository)
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
