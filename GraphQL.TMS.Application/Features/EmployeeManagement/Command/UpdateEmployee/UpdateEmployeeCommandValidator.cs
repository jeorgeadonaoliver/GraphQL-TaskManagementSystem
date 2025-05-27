using FluentValidation;
using GraphQL.TMS.Application.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphQL.TMS.Application.Features.EmployeeManagement.Command.UpdateEmployee
{
    public class UpdateEmployeeCommandValidator : AbstractValidator<UpdateEmployeeCommand>
    {
        IEmployeeRepository _repository;
        public UpdateEmployeeCommandValidator(IEmployeeRepository repository)
        {
            _repository = repository;

            RuleFor(x => x)
                .NotNull()
                .WithMessage("Update Command must not be null.")
                .MustAsync(IsEmployeeExist)
                .WithMessage("Employee Already Exist!");
                
        }

        private async Task<bool> IsEmployeeExist(UpdateEmployeeCommand command, CancellationToken cancellationToken) 
        {
            return await _repository.GetAnyAsync(command.EmployeeId);
        }
    }
}
