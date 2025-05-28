using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphQL.TMS.Application.Features.JopManagement.Query.GetAllJob
{
    public record GetAllJobQuery : IRequest<List<GetAllJobQueryDto>>;
    
}
