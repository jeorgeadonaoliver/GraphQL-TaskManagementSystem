using MediatR;

namespace GraphQL.TMS.Application.Features.EmployeeManagement.Query.GetEmployee
{
    public record GetEmployeeQuery : IRequest<List<GetEmployeeQueryDto>>;
}
