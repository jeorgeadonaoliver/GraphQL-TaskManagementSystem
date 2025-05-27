using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphQL.TMS.Application.Features.EmployeeManagement.Command.UpdateEmployee
{
    public class UpdateEmployeeCommand : IRequest<Unit>
    {
        public int EmployeeId { get; set; }
        public string FirstName { get; set; } = null!;

        public string LastName { get; set; } = null!;

        public string Email { get; set; } = null!;

        public string? PhoneNumber { get; set; }

        public DateOnly HireDate { get; set; } = new DateOnly();

        public int? JobId { get; set; } = 1;

        public int? DepartmentId { get; set; } = 1;

        public decimal? Salary { get; set; }

        public int? ManagerId { get; set; } = 1;

        public int? TeamId { get; set; } = 1;

        public int? RoleId { get; set; } = 1;
    }
}
