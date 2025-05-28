using GraphQL.TMS.Application.Features.EmployeeManagement.Command.CreateEmployee;
using GraphQL.TMS.Application.Features.EmployeeManagement.Command.UpdateEmployee;
using MediatR;

namespace GraphQL.TMS.Api.GraphQL.mutations
{
    [ExtendObjectType("Mutation")]
    public class EmployeeMutation
    {
        ILogger<EmployeeMutation> _logger;
        public EmployeeMutation(ILogger<EmployeeMutation> logger)
        {
            _logger = logger;
        }
        [GraphQLName("createEmployee")]
        public async Task<bool> CreateEmployee([Service] IMediator mediator, CreateEmployeeCommand command) 
        {
            await mediator.Send(command);
            _logger.LogInformation("Adding new Employee Successful!");
            return true;
        }


        [GraphQLName("updateEmployee")]
        public async Task<bool> UpdateEmployee([Service] IMediator mediator, UpdateEmployeeCommand command)
        {
            await mediator.Send(command);
            _logger.LogInformation("Updating Employee Record Successful!.");
            return true;
        }
    }
    
}
