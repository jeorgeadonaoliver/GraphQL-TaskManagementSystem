using GraphQL.TMS.Application.Features.EmployeeManagement.Query.GetEmployee;
using MediatR;

namespace GraphQL.TMS.Api.Endpoints
{
    public static class EmployeeEndpoints
    {
        public static IEndpointRouteBuilder MapEmployeeEndpoints(this IEndpointRouteBuilder app) {

            app.MapGet("/employee", async (IMediator mediator) =>
            {

                var result = await mediator.Send(new GetEmployeeQuery());
                return Results.Ok(result);
            })
            .WithName("GetEmployee")
            .WithTags("Employee")
            .Produces<List<GetEmployeeQueryDto>>(StatusCodes.Status200OK);

            return app;
        }
    }
}
