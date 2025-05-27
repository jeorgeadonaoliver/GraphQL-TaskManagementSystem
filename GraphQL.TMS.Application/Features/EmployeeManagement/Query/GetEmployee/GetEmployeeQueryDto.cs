using GraphQL.TMS.Application.CommonDtos;
namespace GraphQL.TMS.Application.Features.EmployeeManagement.Query.GetEmployee
{
    public class GetEmployeeQueryDto
    {
        public int EmployeeId { get; set; }

        public string FirstName { get; set; } = null!;

        public string LastName { get; set; } = null!;

        public string Email { get; set; } = null!;

        public string? PhoneNumber { get; set; }

        public DateOnly HireDate { get; set; } = new DateOnly();

        public int? JobId { get; set; }

        public int? DepartmentId { get; set; }

        public decimal? Salary { get; set; }

        public int? ManagerId { get; set; }

        public int? TeamId { get; set; }

        public int? RoleId { get; set; }

        public DepartmentDto? Department { get; set; }

        public JobDto? Job { get; set; }

        public RoleDto? Role { get; set; }

        public TeamDto? Team { get; set; }
    }
}
