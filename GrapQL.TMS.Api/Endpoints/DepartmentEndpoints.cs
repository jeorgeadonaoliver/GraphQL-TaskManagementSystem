using GraphQL.TMS.Application.Features.DepartmentManagement.Query.GetAllDepartment;
using GraphQL.TMS.Application.Features.EmployeeManagement.Query.GetEmployee;
using MediatR;

namespace GraphQL.TMS.Api.Endpoints
{
    public static class DepartmentEndpoints
    {
        public static IEndpointRouteBuilder MapDepartmentEndpoints(this IEndpointRouteBuilder app)
        {

            app.MapGet("/department", async (IMediator mediator) =>
            {

                var result = await mediator.Send(new GetAllDepartmentQuery());
                return Results.Ok(result);
            })
            .WithName("GetAllDepartment")
            .WithTags("Department")
            .Produces<List<GetAllDepartmentQueryDto>>(StatusCodes.Status200OK);

            return app;
        }
    }
}
