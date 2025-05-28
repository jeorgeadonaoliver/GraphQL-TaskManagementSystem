using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphQL.TMS.Application.Features.JopManagement.Query.GetAllJob
{
    public class GetAllJobQueryDto
    {
        public int JobId { get; set; }

        public string JobTitle { get; set; } = null!;

        public decimal? MinSalary { get; set; }

        public decimal? MaxSalary { get; set; }
    }
}
