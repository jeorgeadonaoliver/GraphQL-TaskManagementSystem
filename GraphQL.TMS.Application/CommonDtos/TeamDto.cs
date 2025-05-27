using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphQL.TMS.Application.CommonDtos
{
    public class TeamDto
    {
        public int TeamId { get; set; }

        public string TeamName { get; set; } = null!;

        public string? Description { get; set; }
    }
}
