using GraphQL.TMS.Application.Contracts;
using GraphQL.TMS.Application.Extensions;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphQL.TMS.Application.Features.EmployeeManagement.Query.GetEmployeeById
{
    public class GetEmployeeByIdQueryHandler : IRequestHandler<GetEmployeeByIdQuery, GetEmployeeByIdQueryDto>
    {
        IEmployeeRepository _repository;
        public GetEmployeeByIdQueryHandler(IEmployeeRepository repository)
        {
            _repository = repository;
        }

        public async Task<GetEmployeeByIdQueryDto> Handle(GetEmployeeByIdQuery request, CancellationToken cancellationToken)
        {
            var data = await _repository.GetEmployeeByIdAsync(request.id);
            return data.MapToGetEmployeeByIdQueryDto();
        }
    }
}
