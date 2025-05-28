using GraphQL.TMS.Application.Features.EmployeeManagement.Query.GetEmployee;
using GraphQL.TMS.Application.Features.EmployeeManagement.Query.GetEmployeeById;
using MediatR;

namespace GraphQL.TMS.Api.GraphQL.queries;

[ExtendObjectType("Query")]
public class EmployeeQuery
{

    private readonly ILogger<EmployeeQuery> _logger;

    public EmployeeQuery(ILogger<EmployeeQuery> logger)
    {
        _logger = logger;
    }

    [GraphQLName("getEmployee")]
    [GraphQLDescription("Returns all details of employee.")]
    public async Task<List<GetEmployeeQueryDto>> GetEmployee([Service] IMediator mediator)
    {
        _logger.LogInformation("Fetching of GetEmployee using GraphQL...");
        return await mediator.Send(new GetEmployeeQuery());
    }


    [GraphQLName("getEmployeeById")]
    [GraphQLDescription("Returns all details of employee by id.")]
    public async Task<GetEmployeeByIdQueryDto> GetEmployeeById([Service] IMediator mediator, int id)
    {
        _logger.LogInformation("Fetching of GetEmployeeById using GraphQL...");
        return await mediator.Send(new GetEmployeeByIdQuery(id));
    }
}
