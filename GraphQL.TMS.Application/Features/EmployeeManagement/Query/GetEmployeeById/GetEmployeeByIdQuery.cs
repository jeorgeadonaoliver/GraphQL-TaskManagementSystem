using MediatR;

namespace GraphQL.TMS.Application.Features.EmployeeManagement.Query.GetEmployeeById
{
    public record GetEmployeeByIdQuery(int id) : IRequest<GetEmployeeByIdQueryDto>;
}
