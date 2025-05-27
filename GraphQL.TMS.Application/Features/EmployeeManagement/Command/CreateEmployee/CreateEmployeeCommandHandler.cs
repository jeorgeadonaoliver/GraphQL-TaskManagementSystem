using GraphQL.TMS.Application.Contracts;
using GraphQL.TMS.Application.Extensions;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphQL.TMS.Application.Features.EmployeeManagement.Command.CreateEmployee
{
    public class CreateEmployeeCommandHandler : IRequestHandler<CreateEmployeeCommand, Unit>
    {
        IEmployeeRepository _repository;
        public CreateEmployeeCommandHandler(IEmployeeRepository repository)
        {
            _repository = repository;
        }

        public async Task<Unit> Handle(CreateEmployeeCommand request, CancellationToken cancellationToken)
        {
            var validator = new CreateEmployeeCommandValidator(_repository);
            var result = await validator.ValidateAsync(request, cancellationToken);
            result.CheckResult();

            await _repository.CreateAsync(request.MapToEmployee());
            return Unit.Value;
        }
    }
}
