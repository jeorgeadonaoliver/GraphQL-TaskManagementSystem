using GraphQL.TMS.Application.Features.DepartmentManagement.Query.GetAllDepartment;
using GraphQL.TMS.Domain.ProjDbModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphQL.TMS.Application.Extensions
{
    public static class DepartmentExtension
    {
        public static GetAllDepartmentQueryDto MapToGetAllDepartmentQueryDto(this Department department)
        {
            return new GetAllDepartmentQueryDto()
            {
                DepartmentId = department.DepartmentId,
                DepartmentName = department.DepartmentName,
                Location = department.Location,
            };
        }
    }
}
