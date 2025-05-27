using FluentValidation.Validators;
using GraphQL.TMS.Application.Contracts;
using GraphQL.TMS.Application.Extensions;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphQL.TMS.Application.Features.EmployeeManagement.Command.UpdateEmployee
{
    public class UpdateEmployeeCommandHandler : IRequestHandler<UpdateEmployeeCommand, Unit>
    {
        IEmployeeRepository _repository;
        public UpdateEmployeeCommandHandler(IEmployeeRepository repository)
        {
            _repository = repository;
        }

        public async Task<Unit> Handle(UpdateEmployeeCommand request, CancellationToken cancellationToken)
        {
            var validator = new UpdateEmployeeCommandValidator(_repository);
            var result = await validator.ValidateAsync(request, cancellationToken);
            result.CheckResult();

            await _repository.UpdateAsync(request.MapToEmployee());
            return Unit.Value;
        }
    }
}
