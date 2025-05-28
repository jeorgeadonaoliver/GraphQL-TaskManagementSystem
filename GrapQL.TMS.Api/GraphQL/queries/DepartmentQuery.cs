using GraphQL.TMS.Application.Features.DepartmentManagement.Query.GetAllDepartment;
using GraphQL.TMS.Application.Features.EmployeeManagement.Query.GetEmployee;
using MediatR;

namespace GraphQL.TMS.Api.GraphQL.queries
{
    [ExtendObjectType("Query")]
    public class DepartmentQuery
    {
        ILogger<DepartmentQuery> _logger;
        public DepartmentQuery(ILogger<DepartmentQuery> logger)
        {
            _logger = logger;
        }

        [GraphQLName("getDepartment")]
        [GraphQLDescription("Returns list of department.")]
        public async Task<List<GetAllDepartmentQueryDto>> GetDepartment([Service] IMediator mediator)
        {
            _logger.LogInformation("Fetching of GetDepartment using GraphQL...");
            return await mediator.Send(new GetAllDepartmentQuery());
        }
    }
}
