using FluentValidation;
using GraphQL.TMS.Application.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphQL.TMS.Application.Features.EmployeeManagement.Command.CreateEmployee
{
    public class CreateEmployeeCommandValidator : AbstractValidator<CreateEmployeeCommand>
    {
        IEmployeeRepository _repository;
        public CreateEmployeeCommandValidator(IEmployeeRepository repository)
        {
            _repository = repository;

            RuleFor(x => x)
                .NotNull()
                .WithMessage("Command must not be null!")
                .MustAsync(IsEmployeeExist)
                .WithMessage("Employee Already Exist!");

            RuleFor(x => x.HireDate)
                .NotNull()
                .WithMessage("Hire Date must not be null!");
        }

        private async Task<bool> IsEmployeeExist(CreateEmployeeCommand cmd, CancellationToken cancellationToken)
        {
            return !await _repository.GetAnyAsync(cmd.LastName, cmd.FirstName);
        }
    }
}
