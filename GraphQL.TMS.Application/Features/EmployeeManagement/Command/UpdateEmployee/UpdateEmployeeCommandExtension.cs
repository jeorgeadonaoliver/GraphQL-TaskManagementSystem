using GraphQL.TMS.Domain.ProjDbModels;

namespace GraphQL.TMS.Application.Features.EmployeeManagement.Command.UpdateEmployee
{
    public static class UpdateEmployeeCommandExtension
    {
        public static Employee MapToEmployee(this UpdateEmployeeCommand command) 
        {
            return new Employee()
            {
                EmployeeId = command.EmployeeId,
                FirstName = command.FirstName,
                LastName = command.LastName,
                Email = command.Email,
                DepartmentId = command.DepartmentId,
                TeamId = command.TeamId,
                JobId = command.JobId,
                RoleId = command.RoleId,
                HireDate = command.HireDate,
                Salary = command.Salary,
                ManagerId = command.ManagerId
            };
        }
    }
}
