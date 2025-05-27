using GraphQL.TMS.Application.Features.EmployeeManagement.Command.CreateEmployee;
using GraphQL.TMS.Application.Features.EmployeeManagement.Command.UpdateEmployee;
using MediatR;

namespace GraphQL.TMS.Api.GraphQL.mutations
{
    [ExtendObjectType("Mutation")]
    public class EmployeeMutation
    {
        [GraphQLName("createEmployee")]
        public async Task<bool> CreateEmployee([Service] IMediator mediator, CreateEmployeeCommand command) 
        {
           await mediator.Send(command);
           return true;
        }


        [GraphQLName("updateEmployee")]
        public async Task<bool> UpdateEmployee([Service] IMediator mediator, UpdateEmployeeCommand command)
        {
            await mediator.Send(command);
            return true;
        }
    }
    
}
