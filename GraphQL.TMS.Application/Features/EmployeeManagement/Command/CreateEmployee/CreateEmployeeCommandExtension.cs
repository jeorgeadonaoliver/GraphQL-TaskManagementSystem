using GraphQL.TMS.Domain.ProjDbModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace GraphQL.TMS.Application.Features.EmployeeManagement.Command.CreateEmployee
{
    public static class CreateEmployeeCommandExtension
    {
        public static Employee MapToEmployee(this CreateEmployeeCommand cmd) 
        {
            return new Employee() { 
                FirstName = cmd.FirstName,
                LastName = cmd.LastName,
                DepartmentId = cmd.DepartmentId,
                HireDate = cmd.HireDate,
                Email = cmd.Email,
                JobId = cmd.JobId,
                ManagerId = cmd.ManagerId,
                PhoneNumber = cmd.PhoneNumber,
                RoleId = cmd.RoleId,
                Salary = cmd.Salary,
                TeamId = cmd.TeamId,
            };
        }
    }
}
