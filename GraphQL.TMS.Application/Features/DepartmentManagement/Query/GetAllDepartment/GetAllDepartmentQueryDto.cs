using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphQL.TMS.Application.Features.DepartmentManagement.Query.GetAllDepartment
{
    public class GetAllDepartmentQueryDto
    {
        public int DepartmentId { get; set; }

        public string DepartmentName { get; set; } = null!;

        public string? Location { get; set; }
    }
}
