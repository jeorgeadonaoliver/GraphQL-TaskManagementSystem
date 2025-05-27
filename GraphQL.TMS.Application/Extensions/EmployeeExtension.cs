using GraphQL.TMS.Application.CommonDtos;
using GraphQL.TMS.Application.Features.EmployeeManagement.Query.GetEmployee;
using GraphQL.TMS.Application.Features.EmployeeManagement.Query.GetEmployeeById;
using GraphQL.TMS.Domain.ProjDbModels;

namespace GraphQL.TMS.Application.Extensions
{
    public static class EmployeeExtension
    {
        public static GetEmployeeQueryDto MapToGetEmployeeQueryDto(this Employee employee) {

            return new GetEmployeeQueryDto() { 
            
                EmployeeId = employee.EmployeeId,
                LastName = employee.LastName,
                FirstName = employee.FirstName,
                Email = employee.Email,
                PhoneNumber = employee.PhoneNumber,
                DepartmentId = employee.DepartmentId,
                TeamId = employee.TeamId,

                Team = employee.Team == null ? null : new TeamDto { 
                
                    TeamName = employee.Team.TeamName
                },

                Department = employee.Department == null ? null : new DepartmentDto { 
                
                    DepartmentName = employee.Department.DepartmentName,
                },

                Role = employee.Role == null ? null : new RoleDto { 
                
                    RoleName = employee.Role.RoleName
                },

                Job = employee.Job == null ? null : new JobDto { 
                
                    JobTitle = employee.Job.JobTitle,
                },

                HireDate = employee.HireDate,
                JobId = employee.JobId,
                ManagerId = employee.ManagerId,
                RoleId = employee.RoleId,
                Salary = employee.Salary,
            };
        }

        public static GetEmployeeByIdQueryDto MapToGetEmployeeByIdQueryDto(this Employee employee)
        {
            return new GetEmployeeByIdQueryDto()
            {
                EmployeeId = employee.EmployeeId,
                LastName = employee.LastName,
                FirstName = employee.FirstName,
                Email = employee.Email,
                PhoneNumber = employee.PhoneNumber,
                DepartmentId = employee.DepartmentId,
                TeamId = employee.TeamId,

                Team = employee.Team == null ? null : new TeamDto
                {
                    TeamId = employee.Team.TeamId,
                    TeamName = employee.Team.TeamName
                },

                Department = employee.Department == null ? null : new DepartmentDto
                {
                    DepartmentId = employee.Department.DepartmentId,
                    DepartmentName = employee.Department.DepartmentName,
                },

                Role = employee.Role == null ? null : new RoleDto
                {
                    RoleId = employee.Role.RoleId,
                    RoleName = employee.Role.RoleName
                },

                Job = employee.Job == null ? null : new JobDto
                {
                    JobId = employee.Job.JobId,
                    JobTitle = employee.Job.JobTitle,
                },

                HireDate = employee.HireDate,
                JobId = employee.JobId,
                ManagerId = employee.ManagerId,
                RoleId = employee.RoleId,
                Salary = employee.Salary,
            };

        }
    }
}
