using GraphQL.TMS.Application.Contracts;
using GraphQL.TMS.Application.Extensions;
using MediatR;

namespace GraphQL.TMS.Application.Features.EmployeeManagement.Query.GetEmployee
{
    public class GetEmployeeQueryHandler : IRequestHandler<GetEmployeeQuery, List<GetEmployeeQueryDto>>
    {
        IEmployeeRepository _repository;
        public GetEmployeeQueryHandler(IEmployeeRepository repository) => _repository = repository;

        public async Task<List<GetEmployeeQueryDto>> Handle(GetEmployeeQuery request, CancellationToken cancellationToken)
        {
            var data = await _repository.GetAllEmployeeAsync();
            return data.Select(x => x.MapToGetEmployeeQueryDto()).ToList();
        }
    }
}
