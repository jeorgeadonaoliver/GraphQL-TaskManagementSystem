using GraphQL.TMS.Application.Features.EmployeeManagement.Query.GetEmployee;
using GraphQL.TMS.Application.Features.EmployeeManagement.Query.GetEmployeeById;
using MediatR;

namespace GraphQL.TMS.Api.GraphQL.queries;

[ExtendObjectType("Query")]
public class EmployeeQuery
{
    [GraphQLName("getEmployee")]
    [GraphQLDescription("Returns all details of employee.")]
    public async Task<List<GetEmployeeQueryDto>> GetEmployee([Service] IMediator mediator)
        => await mediator.Send(new GetEmployeeQuery());


    [GraphQLName("getEmployeeById")]
    [GraphQLDescription("Returns all details of employee by id.")]
    public async Task<GetEmployeeByIdQueryDto> GetEmployeeById([Service] IMediator mediator, int id)
        => await mediator.Send(new GetEmployeeByIdQuery(id));
}
