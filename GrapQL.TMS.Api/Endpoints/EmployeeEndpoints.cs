using GraphQL.TMS.Application.Features.EmployeeManagement.Command.CreateEmployee;
using GraphQL.TMS.Application.Features.EmployeeManagement.Command.UpdateEmployee;
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

            app.MapPost("/employee", async (IMediator mediator, CreateEmployeeCommand command) =>
            {

                var createEmployee = await mediator.Send(command);
                return Results.Ok(createEmployee);
            })
            .WithName("CreateEmployee")
            .WithTags("Employee")
            .Produces(StatusCodes.Status201Created)
            .ProducesProblem(StatusCodes.Status400BadRequest);

            app.MapPut("/employee", async (IMediator mediator, UpdateEmployeeCommand command) =>
            {

                var updateEmployee = await mediator.Send(command);
                return Results.Ok(updateEmployee);
            })
            .WithName("UpdateEmployee")
            .WithTags("Employee")
            .Produces(StatusCodes.Status202Accepted)
            .ProducesProblem(StatusCodes.Status400BadRequest); 

            return app;
        }
    }
}
